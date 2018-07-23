package org.dddml.wms.domain.inout;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;

public abstract class AbstractInOutStateCommandConverter<TCreateInOut extends InOutCommand.CreateInOut, TMergePatchInOut extends InOutCommand.MergePatchInOut, TDeleteInOut extends InOutCommand.DeleteInOut, TCreateInOutImage extends InOutImageCommand.CreateInOutImage, TMergePatchInOutImage extends InOutImageCommand.MergePatchInOutImage, TRemoveInOutImage extends InOutImageCommand.RemoveInOutImage, TCreateInOutLine extends InOutLineCommand.CreateInOutLine, TMergePatchInOutLine extends InOutLineCommand.MergePatchInOutLine, TRemoveInOutLine extends InOutLineCommand.RemoveInOutLine, TCreateInOutLineImage extends InOutLineImageCommand.CreateInOutLineImage, TMergePatchInOutLineImage extends InOutLineImageCommand.MergePatchInOutLineImage, TRemoveInOutLineImage extends InOutLineImageCommand.RemoveInOutLineImage>
{
    public InOutCommand toCreateOrMergePatchInOut(InOutState state)
    {
        //where TCreateInOut : ICreateInOut, new()
        //where TMergePatchInOut : IMergePatchInOut, new()
        boolean bUnsaved = state.isStateUnsaved();
        if (bUnsaved)
        {
            return toCreateInOut(state);
        }
        else 
        {
            return toMergePatchInOut(state);
        }
    }

    public TDeleteInOut toDeleteInOut(InOutState state) //where TDeleteInOut : IDeleteInOut, new()
    {
        TDeleteInOut cmd = newDeleteInOut();
        cmd.setDocumentNumber(state.getDocumentNumber());
        cmd.setVersion(state.getVersion());

        return cmd;
    }

    public TMergePatchInOut toMergePatchInOut(InOutState state) //where TMergePatchInOut : IMergePatchInOut, new()
    {
        TMergePatchInOut cmd = newMergePatchInOut();

        cmd.setVersion(state.getVersion());

        cmd.setDocumentNumber(state.getDocumentNumber());
        cmd.setPosted(state.getPosted());
        cmd.setProcessed(state.getProcessed());
        cmd.setProcessing(state.getProcessing());
        cmd.setDocumentTypeId(state.getDocumentTypeId());
        cmd.setDescription(state.getDescription());
        cmd.setOrderId(state.getOrderId());
        cmd.setDateOrdered(state.getDateOrdered());
        cmd.setIsPrinted(state.getIsPrinted());
        cmd.setMovementTypeId(state.getMovementTypeId());
        cmd.setMovementDate(state.getMovementDate());
        cmd.setBusinessPartnerId(state.getBusinessPartnerId());
        cmd.setWarehouseId(state.getWarehouseId());
        cmd.setPOReference(state.getPOReference());
        cmd.setFreightAmount(state.getFreightAmount());
        cmd.setShipperId(state.getShipperId());
        cmd.setChargeAmount(state.getChargeAmount());
        cmd.setDatePrinted(state.getDatePrinted());
        cmd.setCreatedFrom(state.getCreatedFrom());
        cmd.setSalesRepresentativeId(state.getSalesRepresentativeId());
        cmd.setNumberOfPackages(state.getNumberOfPackages());
        cmd.setPickDate(state.getPickDate());
        cmd.setShipDate(state.getShipDate());
        cmd.setTrackingNumber(state.getTrackingNumber());
        cmd.setDateReceived(state.getDateReceived());
        cmd.setIsInTransit(state.getIsInTransit());
        cmd.setIsApproved(state.getIsApproved());
        cmd.setIsInDispute(state.getIsInDispute());
        cmd.setRmaDocumentNumber(state.getRmaDocumentNumber());
        cmd.setReversalDocumentNumber(state.getReversalDocumentNumber());
        cmd.setActive(state.getActive());
            
        if (state.getPosted() == null) { cmd.setIsPropertyPostedRemoved(true); }
        if (state.getProcessed() == null) { cmd.setIsPropertyProcessedRemoved(true); }
        if (state.getProcessing() == null) { cmd.setIsPropertyProcessingRemoved(true); }
        if (state.getDocumentTypeId() == null) { cmd.setIsPropertyDocumentTypeIdRemoved(true); }
        if (state.getDescription() == null) { cmd.setIsPropertyDescriptionRemoved(true); }
        if (state.getOrderId() == null) { cmd.setIsPropertyOrderIdRemoved(true); }
        if (state.getDateOrdered() == null) { cmd.setIsPropertyDateOrderedRemoved(true); }
        if (state.getIsPrinted() == null) { cmd.setIsPropertyIsPrintedRemoved(true); }
        if (state.getMovementTypeId() == null) { cmd.setIsPropertyMovementTypeIdRemoved(true); }
        if (state.getMovementDate() == null) { cmd.setIsPropertyMovementDateRemoved(true); }
        if (state.getBusinessPartnerId() == null) { cmd.setIsPropertyBusinessPartnerIdRemoved(true); }
        if (state.getWarehouseId() == null) { cmd.setIsPropertyWarehouseIdRemoved(true); }
        if (state.getPOReference() == null) { cmd.setIsPropertyPOReferenceRemoved(true); }
        if (state.getFreightAmount() == null) { cmd.setIsPropertyFreightAmountRemoved(true); }
        if (state.getShipperId() == null) { cmd.setIsPropertyShipperIdRemoved(true); }
        if (state.getChargeAmount() == null) { cmd.setIsPropertyChargeAmountRemoved(true); }
        if (state.getDatePrinted() == null) { cmd.setIsPropertyDatePrintedRemoved(true); }
        if (state.getCreatedFrom() == null) { cmd.setIsPropertyCreatedFromRemoved(true); }
        if (state.getSalesRepresentativeId() == null) { cmd.setIsPropertySalesRepresentativeIdRemoved(true); }
        if (state.getNumberOfPackages() == null) { cmd.setIsPropertyNumberOfPackagesRemoved(true); }
        if (state.getPickDate() == null) { cmd.setIsPropertyPickDateRemoved(true); }
        if (state.getShipDate() == null) { cmd.setIsPropertyShipDateRemoved(true); }
        if (state.getTrackingNumber() == null) { cmd.setIsPropertyTrackingNumberRemoved(true); }
        if (state.getDateReceived() == null) { cmd.setIsPropertyDateReceivedRemoved(true); }
        if (state.getIsInTransit() == null) { cmd.setIsPropertyIsInTransitRemoved(true); }
        if (state.getIsApproved() == null) { cmd.setIsPropertyIsApprovedRemoved(true); }
        if (state.getIsInDispute() == null) { cmd.setIsPropertyIsInDisputeRemoved(true); }
        if (state.getRmaDocumentNumber() == null) { cmd.setIsPropertyRmaDocumentNumberRemoved(true); }
        if (state.getReversalDocumentNumber() == null) { cmd.setIsPropertyReversalDocumentNumberRemoved(true); }
        if (state.getActive() == null) { cmd.setIsPropertyActiveRemoved(true); }
        for (InOutImageState d : state.getInOutImages())
        {
            InOutImageCommand c = getInOutImageStateCommandConverter().toCreateOrMergePatchInOutImage(d);
            cmd.getInOutImageCommands().add(c);
        }
        for (InOutLineState d : state.getInOutLines())
        {
            InOutLineCommand c = getInOutLineStateCommandConverter().toCreateOrMergePatchInOutLine(d);
            cmd.getInOutLineCommands().add(c);
        }
        return cmd;
    }

    public TCreateInOut toCreateInOut(InOutState state) //where TCreateInOut : ICreateInOut, new()
    {
        TCreateInOut cmd = newCreateInOut();

        cmd.setVersion(state.getVersion());
        cmd.setDocumentNumber(state.getDocumentNumber());
        cmd.setPosted(state.getPosted());
        cmd.setProcessed(state.getProcessed());
        cmd.setProcessing(state.getProcessing());
        cmd.setDocumentTypeId(state.getDocumentTypeId());
        cmd.setDescription(state.getDescription());
        cmd.setOrderId(state.getOrderId());
        cmd.setDateOrdered(state.getDateOrdered());
        cmd.setIsPrinted(state.getIsPrinted());
        cmd.setMovementTypeId(state.getMovementTypeId());
        cmd.setMovementDate(state.getMovementDate());
        cmd.setBusinessPartnerId(state.getBusinessPartnerId());
        cmd.setWarehouseId(state.getWarehouseId());
        cmd.setPOReference(state.getPOReference());
        cmd.setFreightAmount(state.getFreightAmount());
        cmd.setShipperId(state.getShipperId());
        cmd.setChargeAmount(state.getChargeAmount());
        cmd.setDatePrinted(state.getDatePrinted());
        cmd.setCreatedFrom(state.getCreatedFrom());
        cmd.setSalesRepresentativeId(state.getSalesRepresentativeId());
        cmd.setNumberOfPackages(state.getNumberOfPackages());
        cmd.setPickDate(state.getPickDate());
        cmd.setShipDate(state.getShipDate());
        cmd.setTrackingNumber(state.getTrackingNumber());
        cmd.setDateReceived(state.getDateReceived());
        cmd.setIsInTransit(state.getIsInTransit());
        cmd.setIsApproved(state.getIsApproved());
        cmd.setIsInDispute(state.getIsInDispute());
        cmd.setRmaDocumentNumber(state.getRmaDocumentNumber());
        cmd.setReversalDocumentNumber(state.getReversalDocumentNumber());
        cmd.setActive(state.getActive());
        for (InOutImageState d : state.getInOutImages())
        {
            InOutImageCommand.CreateInOutImage c = getInOutImageStateCommandConverter().toCreateInOutImage(d);
            cmd.getInOutImages().add(c);
        }
        for (InOutLineState d : state.getInOutLines())
        {
            InOutLineCommand.CreateInOutLine c = getInOutLineStateCommandConverter().toCreateInOutLine(d);
            cmd.getInOutLines().add(c);
        }
        return cmd;
    }

    protected abstract AbstractInOutImageStateCommandConverter<TCreateInOutImage, TMergePatchInOutImage, TRemoveInOutImage>
        getInOutImageStateCommandConverter();

    protected abstract AbstractInOutLineStateCommandConverter<TCreateInOutLine, TMergePatchInOutLine, TRemoveInOutLine, TCreateInOutLineImage, TMergePatchInOutLineImage, TRemoveInOutLineImage>
        getInOutLineStateCommandConverter();

    protected abstract TCreateInOut newCreateInOut();

    protected abstract TMergePatchInOut newMergePatchInOut(); 

    protected abstract TDeleteInOut newDeleteInOut();

    public static class SimpleInOutStateCommandConverter extends AbstractInOutStateCommandConverter<AbstractInOutCommand.SimpleCreateInOut, AbstractInOutCommand.SimpleMergePatchInOut, AbstractInOutCommand.SimpleDeleteInOut, AbstractInOutImageCommand.SimpleCreateInOutImage, AbstractInOutImageCommand.SimpleMergePatchInOutImage, AbstractInOutImageCommand.SimpleRemoveInOutImage, AbstractInOutLineCommand.SimpleCreateInOutLine, AbstractInOutLineCommand.SimpleMergePatchInOutLine, AbstractInOutLineCommand.SimpleRemoveInOutLine, AbstractInOutLineImageCommand.SimpleCreateInOutLineImage, AbstractInOutLineImageCommand.SimpleMergePatchInOutLineImage, AbstractInOutLineImageCommand.SimpleRemoveInOutLineImage>
    {
        @Override
        protected AbstractInOutCommand.SimpleCreateInOut newCreateInOut() {
            return new AbstractInOutCommand.SimpleCreateInOut();
        }

        @Override
        protected AbstractInOutCommand.SimpleMergePatchInOut newMergePatchInOut() {
            return new AbstractInOutCommand.SimpleMergePatchInOut();
        }

        @Override
        protected AbstractInOutCommand.SimpleDeleteInOut newDeleteInOut() {
            return new AbstractInOutCommand.SimpleDeleteInOut();
        }

        @Override
        protected AbstractInOutImageStateCommandConverter<AbstractInOutImageCommand.SimpleCreateInOutImage, AbstractInOutImageCommand.SimpleMergePatchInOutImage, AbstractInOutImageCommand.SimpleRemoveInOutImage> getInOutImageStateCommandConverter()
        {
            return new AbstractInOutImageStateCommandConverter.SimpleInOutImageStateCommandConverter();
        }

        @Override
        protected AbstractInOutLineStateCommandConverter<AbstractInOutLineCommand.SimpleCreateInOutLine, AbstractInOutLineCommand.SimpleMergePatchInOutLine, AbstractInOutLineCommand.SimpleRemoveInOutLine, AbstractInOutLineImageCommand.SimpleCreateInOutLineImage, AbstractInOutLineImageCommand.SimpleMergePatchInOutLineImage, AbstractInOutLineImageCommand.SimpleRemoveInOutLineImage> getInOutLineStateCommandConverter()
        {
            return new AbstractInOutLineStateCommandConverter.SimpleInOutLineStateCommandConverter();
        }


    }

}

