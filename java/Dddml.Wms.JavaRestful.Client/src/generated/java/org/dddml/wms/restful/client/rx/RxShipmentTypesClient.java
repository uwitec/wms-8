package org.dddml.wms.restful.client.rx;

import java.util.List;
import java.util.Map;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.PATCH;
import retrofit2.http.PUT;
import retrofit2.http.POST;
import retrofit2.http.Path;
import retrofit2.http.Query;
import rx.Observable;

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.shipmenttype.*;

public interface RxShipmentTypesClient {

    @Headers("Accept: application/json")
    @GET("ShipmentTypes")
    Observable<List<ShipmentTypeStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("ShipmentTypes/_count")
    Observable<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("ShipmentTypes/{shipmentTypeId}")
    Observable<ShipmentTypeStateDto> get(@Path("shipmentTypeId") String shipmentTypeId, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("ShipmentTypes/_metadata/filteringFields")
    Observable<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("ShipmentTypes/{shipmentTypeId}/_historyStates/{version}")
    Observable<ShipmentTypeStateDto> getHistoryState(@Path("shipmentTypeId") String shipmentTypeId, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("ShipmentTypes/{shipmentTypeId}")
    Observable<String> put(@Path("shipmentTypeId") String shipmentTypeId, @Body CreateOrMergePatchShipmentTypeDto.CreateShipmentTypeDto value);

    @Headers("Accept: application/json")
    @POST("ShipmentTypes")
    Observable<String> post(@Body CreateOrMergePatchShipmentTypeDto.CreateShipmentTypeDto value);

    @Headers("Accept: application/json")
    @PATCH("ShipmentTypes/{shipmentTypeId}")
    Observable<String> patch(@Path("shipmentTypeId") String shipmentTypeId, @Body CreateOrMergePatchShipmentTypeDto.MergePatchShipmentTypeDto value);

    @Headers("Accept: application/json")
    @DELETE("ShipmentTypes/{shipmentTypeId}")
    Observable<String> delete(@Path("shipmentTypeId") String shipmentTypeId, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

