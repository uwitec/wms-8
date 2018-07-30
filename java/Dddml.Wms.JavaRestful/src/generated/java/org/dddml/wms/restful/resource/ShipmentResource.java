package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.shipment.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@RequestMapping(path = "Shipments", produces = MediaType.APPLICATION_JSON_VALUE)
@RestController
public class ShipmentResource {


    @Autowired
    private ShipmentApplicationService shipmentApplicationService;


    @GetMapping
    public ShipmentStateDto[] getAll( HttpServletRequest request,
                                   @RequestParam(value = "sort", required = false) String sort,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "firstResult", defaultValue = "0") Integer firstResult,
                                   @RequestParam(value = "maxResults", defaultValue = "2147483647") Integer maxResults,
                                   @RequestParam(value = "filter", required = false) String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<ShipmentState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = shipmentApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (ShipmentMetadata.aliasMap.containsKey(n) ? ShipmentMetadata.aliasMap.get(n) : n)),
                        ShipmentResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = shipmentApplicationService.get(
                        ShipmentResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        ShipmentResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            ShipmentStateDto.DtoConverter dtoConverter = new ShipmentStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toShipmentStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_page")
    public Page<ShipmentStateDto> getPage( HttpServletRequest request,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "page", defaultValue = "0") Integer page,
                                   @RequestParam(value = "size", required = false) @NotNull Integer size) {
        try {
            List<String> sort = ShipmentResourceUtils.getQuerySorts(request.getParameterMap());
            Integer firstResult = (page == null ? 0 : page) * size;
            Integer maxResults = (size ==null ? 0 : size);
            Iterable<ShipmentState> states = null; 
            Iterable<Map.Entry<String, Object>> queryFilterMap = ShipmentResourceUtils.getQueryFilterMap(request.getParameterMap());
            states = shipmentApplicationService.get(
                        queryFilterMap,
                        ShipmentResourceUtils.getQuerySorts(request.getParameterMap()),
                        firstResult, maxResults);
            long count = shipmentApplicationService.getCount(queryFilterMap);

            ShipmentStateDto.DtoConverter dtoConverter = new ShipmentStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            Page.PageImpl<ShipmentStateDto> statePage =  new Page.PageImpl<>(dtoConverter.toShipmentStateDtoList(states), 0);//todo
            statePage.setSize(size);
            statePage.setNumber(page);
            return statePage;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}")
    public ShipmentStateDto get(@PathVariable("id") String id, @RequestParam(value = "fields", required = false) String fields) {
        try {
            String idObj = id;
            ShipmentState state = shipmentApplicationService.get(idObj);
            if (state == null) { return null; }

            ShipmentStateDto.DtoConverter dtoConverter = new ShipmentStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toShipmentStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_count")
    public long getCount( HttpServletRequest request,
                         @RequestParam(value = "filter", required = false) String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = shipmentApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (ShipmentMetadata.aliasMap.containsKey(n) ? ShipmentMetadata.aliasMap.get(n) : n)));
            } else {
                count = shipmentApplicationService.getCount(ShipmentResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PostMapping
    public String post(@RequestBody CreateOrMergePatchShipmentDto.CreateShipmentDto value,  HttpServletResponse response) {
        try {
            ShipmentCommand.CreateShipment cmd = value.toCreateShipment();
            if (cmd.getShipmentId() == null) {
                throw DomainError.named("nullId", "Aggregate Id in cmd is null, aggregate name: %1$s.", "Shipment");
            }
            shipmentApplicationService.when(cmd);

            response.setStatus(HttpServletResponse.SC_CREATED);
            return cmd.getShipmentId();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}")
    public void put(@PathVariable("id") String id, @RequestBody CreateOrMergePatchShipmentDto value) {
        try {
            if (value.getVersion() != null) {
                value.setCommandType(Command.COMMAND_TYPE_MERGE_PATCH);
                ShipmentCommand.MergePatchShipment cmd = (ShipmentCommand.MergePatchShipment) value.toCommand();
                ShipmentResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
                shipmentApplicationService.when(cmd);
                return;
            }

            value.setCommandType(Command.COMMAND_TYPE_CREATE);
            ShipmentCommand.CreateShipment cmd = (ShipmentCommand.CreateShipment) value.toCommand();
            ShipmentResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            shipmentApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PatchMapping("{id}")
    public void patch(@PathVariable("id") String id, @RequestBody CreateOrMergePatchShipmentDto.MergePatchShipmentDto value) {
        try {

            ShipmentCommand.MergePatchShipment cmd = value.toMergePatchShipment();
            ShipmentResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            shipmentApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}/_commands/Import")
    public void _import(@PathVariable("id") String id, @RequestBody ShipmentCommands.Import content) {
        try {

            ShipmentCommands.Import cmd = content;//.toImport();
            String idObj = id;
            if (cmd.getShipmentId() == null) {
                cmd.setShipmentId(idObj);
            } else if (!cmd.getShipmentId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, cmd.getShipmentId());
            }
            shipmentApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}/_commands/Ship")
    public void ship(@PathVariable("id") String id, @RequestBody ShipmentCommands.Ship content) {
        try {

            ShipmentCommands.Ship cmd = content;//.toShip();
            String idObj = id;
            if (cmd.getShipmentId() == null) {
                cmd.setShipmentId(idObj);
            } else if (!cmd.getShipmentId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, cmd.getShipmentId());
            }
            shipmentApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}/_commands/ReceiveItem")
    public void receiveItem(@PathVariable("id") String id, @RequestBody ShipmentCommands.ReceiveItem content) {
        try {

            ShipmentCommands.ReceiveItem cmd = content;//.toReceiveItem();
            String idObj = id;
            if (cmd.getShipmentId() == null) {
                cmd.setShipmentId(idObj);
            } else if (!cmd.getShipmentId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, cmd.getShipmentId());
            }
            shipmentApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}/_commands/ConfirmAllItemsReceived")
    public void confirmAllItemsReceived(@PathVariable("id") String id, @RequestBody ShipmentCommands.ConfirmAllItemsReceived content) {
        try {

            ShipmentCommands.ConfirmAllItemsReceived cmd = content;//.toConfirmAllItemsReceived();
            String idObj = id;
            if (cmd.getShipmentId() == null) {
                cmd.setShipmentId(idObj);
            } else if (!cmd.getShipmentId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, cmd.getShipmentId());
            }
            shipmentApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_metadata/filteringFields")
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            ShipmentMetadata.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_events/{version}")
    public ShipmentEvent getStateEvent(@PathVariable("id") String id, @PathVariable("version") long version) {
        try {

            String idObj = id;
            //ShipmentStateEventDtoConverter dtoConverter = getShipmentStateEventDtoConverter();
            return shipmentApplicationService.getEvent(idObj, version);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_historyStates/{version}")
    public ShipmentStateDto getHistoryState(@PathVariable("id") String id, @PathVariable("version") long version, @RequestParam(value = "fields", required = false) String fields) {
        try {

            String idObj = id;
            ShipmentStateDto.DtoConverter dtoConverter = new ShipmentStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toShipmentStateDto(shipmentApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{shipmentId}/ShipmentItems/{shipmentItemSeqId}")
    public ShipmentItemStateDto getShipmentItem(@PathVariable("shipmentId") String shipmentId, @PathVariable("shipmentItemSeqId") String shipmentItemSeqId) {
        try {

            ShipmentItemState state = shipmentApplicationService.getShipmentItem(shipmentId, shipmentItemSeqId);
            if (state == null) { return null; }
            ShipmentItemStateDto.DtoConverter dtoConverter = new ShipmentItemStateDto.DtoConverter();
            ShipmentItemStateDto stateDto = dtoConverter.toShipmentItemStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @PutMapping("{shipmentId}/ShipmentItems/{shipmentItemSeqId}")
    public void putShipmentItem(@PathVariable("shipmentId") String shipmentId, @PathVariable("shipmentItemSeqId") String shipmentItemSeqId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId,
                       @RequestBody CreateOrMergePatchShipmentItemDto.MergePatchShipmentItemDto body) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ShipmentItemCommand.MergePatchShipmentItem mergePatchShipmentItem = body.toMergePatchShipmentItem();
            mergePatchShipmentItem.setShipmentItemSeqId(shipmentItemSeqId);
            mergePatchShipment.getShipmentItemCommands().add(mergePatchShipmentItem);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DeleteMapping("{shipmentId}/ShipmentItems/{shipmentItemSeqId}")
    public void deleteShipmentItem(@PathVariable("shipmentId") String shipmentId, @PathVariable("shipmentItemSeqId") String shipmentItemSeqId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId);// != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId);// != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ShipmentItemCommand.RemoveShipmentItem removeShipmentItem = new AbstractShipmentItemCommand.SimpleRemoveShipmentItem();
            removeShipmentItem.setShipmentItemSeqId(shipmentItemSeqId);
            mergePatchShipment.getShipmentItemCommands().add(removeShipmentItem);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{shipmentId}/ShipmentItems/")
    public ShipmentItemStateDto[] getShipmentItems(@PathVariable("shipmentId") String shipmentId) {
        try {
            Iterable<ShipmentItemState> states = shipmentApplicationService.getShipmentItems(shipmentId);
            if (states == null) { return null; }
            ShipmentItemStateDto.DtoConverter dtoConverter = new ShipmentItemStateDto.DtoConverter();
            dtoConverter.setAllFieldsReturned(true);
            return dtoConverter.toShipmentItemStateDtoArray(states);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @PostMapping("{shipmentId}/ShipmentItems/")
    public void postShipmentItems(@PathVariable("shipmentId") String shipmentId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId,
                       @RequestBody CreateOrMergePatchShipmentItemDto.CreateShipmentItemDto body) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ShipmentItemCommand.CreateShipmentItem createShipmentItem = body.toCreateShipmentItem();
            mergePatchShipment.getShipmentItemCommands().add(createShipmentItem);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{shipmentId}/ShipmentReceipts/{receiptSeqId}")
    public ShipmentReceiptStateDto getShipmentReceipt(@PathVariable("shipmentId") String shipmentId, @PathVariable("receiptSeqId") String receiptSeqId) {
        try {

            ShipmentReceiptState state = shipmentApplicationService.getShipmentReceipt(shipmentId, receiptSeqId);
            if (state == null) { return null; }
            ShipmentReceiptStateDto.DtoConverter dtoConverter = new ShipmentReceiptStateDto.DtoConverter();
            ShipmentReceiptStateDto stateDto = dtoConverter.toShipmentReceiptStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @PutMapping("{shipmentId}/ShipmentReceipts/{receiptSeqId}")
    public void putShipmentReceipt(@PathVariable("shipmentId") String shipmentId, @PathVariable("receiptSeqId") String receiptSeqId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId,
                       @RequestBody CreateOrMergePatchShipmentReceiptDto.MergePatchShipmentReceiptDto body) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ShipmentReceiptCommand.MergePatchShipmentReceipt mergePatchShipmentReceipt = body.toMergePatchShipmentReceipt();
            mergePatchShipmentReceipt.setReceiptSeqId(receiptSeqId);
            mergePatchShipment.getShipmentReceiptCommands().add(mergePatchShipmentReceipt);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DeleteMapping("{shipmentId}/ShipmentReceipts/{receiptSeqId}")
    public void deleteShipmentReceipt(@PathVariable("shipmentId") String shipmentId, @PathVariable("receiptSeqId") String receiptSeqId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId);// != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId);// != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ShipmentReceiptCommand.RemoveShipmentReceipt removeShipmentReceipt = new AbstractShipmentReceiptCommand.SimpleRemoveShipmentReceipt();
            removeShipmentReceipt.setReceiptSeqId(receiptSeqId);
            mergePatchShipment.getShipmentReceiptCommands().add(removeShipmentReceipt);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{shipmentId}/ShipmentReceipts/")
    public ShipmentReceiptStateDto[] getShipmentReceipts(@PathVariable("shipmentId") String shipmentId) {
        try {
            Iterable<ShipmentReceiptState> states = shipmentApplicationService.getShipmentReceipts(shipmentId);
            if (states == null) { return null; }
            ShipmentReceiptStateDto.DtoConverter dtoConverter = new ShipmentReceiptStateDto.DtoConverter();
            dtoConverter.setAllFieldsReturned(true);
            return dtoConverter.toShipmentReceiptStateDtoArray(states);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @PostMapping("{shipmentId}/ShipmentReceipts/")
    public void postShipmentReceipts(@PathVariable("shipmentId") String shipmentId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId,
                       @RequestBody CreateOrMergePatchShipmentReceiptDto.CreateShipmentReceiptDto body) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ShipmentReceiptCommand.CreateShipmentReceipt createShipmentReceipt = body.toCreateShipmentReceipt();
            mergePatchShipment.getShipmentReceiptCommands().add(createShipmentReceipt);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{shipmentId}/ItemIssuances/{itemIssuanceSeqId}")
    public ItemIssuanceStateDto getItemIssuance(@PathVariable("shipmentId") String shipmentId, @PathVariable("itemIssuanceSeqId") String itemIssuanceSeqId) {
        try {

            ItemIssuanceState state = shipmentApplicationService.getItemIssuance(shipmentId, itemIssuanceSeqId);
            if (state == null) { return null; }
            ItemIssuanceStateDto.DtoConverter dtoConverter = new ItemIssuanceStateDto.DtoConverter();
            ItemIssuanceStateDto stateDto = dtoConverter.toItemIssuanceStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @PutMapping("{shipmentId}/ItemIssuances/{itemIssuanceSeqId}")
    public void putItemIssuance(@PathVariable("shipmentId") String shipmentId, @PathVariable("itemIssuanceSeqId") String itemIssuanceSeqId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId,
                       @RequestBody CreateOrMergePatchItemIssuanceDto.MergePatchItemIssuanceDto body) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ItemIssuanceCommand.MergePatchItemIssuance mergePatchItemIssuance = body.toMergePatchItemIssuance();
            mergePatchItemIssuance.setItemIssuanceSeqId(itemIssuanceSeqId);
            mergePatchShipment.getItemIssuanceCommands().add(mergePatchItemIssuance);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DeleteMapping("{shipmentId}/ItemIssuances/{itemIssuanceSeqId}")
    public void deleteItemIssuance(@PathVariable("shipmentId") String shipmentId, @PathVariable("itemIssuanceSeqId") String itemIssuanceSeqId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId);// != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId);// != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ItemIssuanceCommand.RemoveItemIssuance removeItemIssuance = new AbstractItemIssuanceCommand.SimpleRemoveItemIssuance();
            removeItemIssuance.setItemIssuanceSeqId(itemIssuanceSeqId);
            mergePatchShipment.getItemIssuanceCommands().add(removeItemIssuance);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{shipmentId}/ItemIssuances/")
    public ItemIssuanceStateDto[] getItemIssuances(@PathVariable("shipmentId") String shipmentId) {
        try {
            Iterable<ItemIssuanceState> states = shipmentApplicationService.getItemIssuances(shipmentId);
            if (states == null) { return null; }
            ItemIssuanceStateDto.DtoConverter dtoConverter = new ItemIssuanceStateDto.DtoConverter();
            dtoConverter.setAllFieldsReturned(true);
            return dtoConverter.toItemIssuanceStateDtoArray(states);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @PostMapping("{shipmentId}/ItemIssuances/")
    public void postItemIssuances(@PathVariable("shipmentId") String shipmentId,
                       @RequestParam(value = "commandId", required = false) String commandId,
                       @RequestParam(value = "version", required = false) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId,
                       @RequestBody CreateOrMergePatchItemIssuanceDto.CreateItemIssuanceDto body) {
        try {
            ShipmentCommand.MergePatchShipment mergePatchShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
            mergePatchShipment.setShipmentId(shipmentId);
            mergePatchShipment.setCommandId(commandId != null && !commandId.isEmpty() ? commandId : body.getCommandId());
            if (version != null) { mergePatchShipment.setVersion(version); }
            mergePatchShipment.setRequesterId(requesterId != null && !requesterId.isEmpty() ? requesterId : body.getRequesterId());
            ItemIssuanceCommand.CreateItemIssuance createItemIssuance = body.toCreateItemIssuance();
            mergePatchShipment.getItemIssuanceCommands().add(createItemIssuance);
            shipmentApplicationService.when(mergePatchShipment);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    //protected  ShipmentStateEventDtoConverter getShipmentStateEventDtoConverter() {
    //    return new ShipmentStateEventDtoConverter();
    //}

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new ShipmentPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class ShipmentPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return ShipmentResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class ShipmentResourceUtils {

        public static List<String> getQueryOrders(String str, String separator) {
            List<String> orders = new ArrayList<>();
            if (StringHelper.isNullOrEmpty(str)) {
                return orders;
            }
            String[] splits = str.split(separator);
            for (String item : splits) {
                if (!StringHelper.isNullOrEmpty(item)) {
                    orders.add(item);
                }
            }
            return orders;
        }

        public static List<String> getQuerySorts(Map<String, String[]> queryNameValuePairs) {
            String[] values = queryNameValuePairs.get("sort");
            List<String> sorts = new ArrayList<>();
            if (values == null) {
                return null;
            }
            if (values.length == 1
                    && !values[0].toLowerCase().endsWith(",asc")
                    && !values[0].toLowerCase().endsWith(",desc")) {
                return getQueryOrders(values[0], ",");
            }
            Arrays.stream(values).forEach(s -> {
                if (s.toLowerCase().endsWith(",asc")) {
                    String f = s.substring(0, s.length() - 4).trim();
                    if (!f.isEmpty()) {
                        sorts.add(f);
                    }
                } else if (s.toLowerCase().endsWith(",desc")) {
                    String f = s.substring(0, s.length() - 5).trim();
                    if (!f.isEmpty()) {
                        sorts.add("-" + f);
                    }
                } else {
                    String f = s.trim();
                    if (!f.isEmpty()) {
                        sorts.add(f);
                    }
                }
            });
            return sorts;
        }

        public static void setNullIdOrThrowOnInconsistentIds(String id, ShipmentCommand value) {
            String idObj = id;
            if (value.getShipmentId() == null) {
                value.setShipmentId(idObj);
            } else if (!value.getShipmentId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getShipmentId());
            }
        }
    


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (ShipmentMetadata.aliasMap.containsKey(fieldName)) {
                return ShipmentMetadata.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (ShipmentMetadata.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = ShipmentMetadata.propertyTypeMap.get(propertyName);
                if (!StringHelper.isNullOrEmpty(propertyType)) {
                    if (org.dddml.wms.domain.meta.BoundedContextMetadata.CLASS_MAP.containsKey(propertyType)) {
                        return org.dddml.wms.domain.meta.BoundedContextMetadata.CLASS_MAP.get(propertyType);
                    }
                }
            }
            return String.class;
        }

        public static Iterable<Map.Entry<String, Object>> getQueryFilterMap(Map<String, String[]> queryNameValuePairs) {
            Map<String, Object> filter = new HashMap<>();
            queryNameValuePairs.forEach((key, values) -> {
                if (values.length > 0) {
                    String pName = getFilterPropertyName(key);
                    if (!StringHelper.isNullOrEmpty(pName)) {
                        Class pClass = getFilterPropertyType(pName);
                        filter.put(pName, ApplicationContext.current.getTypeConverter().convertFromString(pClass, values[0]));
                    }
                }
            });
            return filter.entrySet();
        }

        public static ShipmentStateDto[] toShipmentStateDtoArray(Iterable<String> ids) {
            List<ShipmentStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                ShipmentStateDto dto = new ShipmentStateDto();
                dto.setShipmentId(id);
                states.add(dto);
            });
            return states.toArray(new ShipmentStateDto[0]);
        }

    }

}

