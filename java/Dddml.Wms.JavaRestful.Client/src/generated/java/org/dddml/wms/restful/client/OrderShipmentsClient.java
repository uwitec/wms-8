package org.dddml.wms.restful.client;

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

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.ordershipment.*;

public interface OrderShipmentsClient {

    @Headers("Accept: application/json")
    @GET("OrderShipments")
    Call<List<OrderShipmentStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("OrderShipments/_count")
    Call<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("OrderShipments/{orderShipmentId}")
    Call<OrderShipmentStateDto> get(@Path("orderShipmentId") String orderShipmentId, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("OrderShipments/_metadata/filteringFields")
    Call<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("OrderShipments/{orderShipmentId}/_stateEvents/{version}")
    Call<OrderShipmentStateEventDto> getStateEvent(@Path("orderShipmentId") String orderShipmentId, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("OrderShipments/{orderShipmentId}/_historyStates/{version}")
    Call<OrderShipmentStateDto> getHistoryState(@Path("orderShipmentId") String orderShipmentId, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("OrderShipments/{orderShipmentId}")
    Call<String> put(@Path("orderShipmentId") String orderShipmentId, @Body CreateOrMergePatchOrderShipmentDto.CreateOrderShipmentDto value);

    @Headers("Accept: application/json")
    @POST("OrderShipments")
    Call<OrderShipmentId> post(@Body CreateOrMergePatchOrderShipmentDto.CreateOrderShipmentDto value);

    @Headers("Accept: application/json")
    @PATCH("OrderShipments/{orderShipmentId}")
    Call<String> patch(@Path("orderShipmentId") String orderShipmentId, @Body CreateOrMergePatchOrderShipmentDto.MergePatchOrderShipmentDto value);

    @Headers("Accept: application/json")
    @DELETE("OrderShipments/{orderShipmentId}")
    Call<String> delete(@Path("orderShipmentId") String orderShipmentId, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

