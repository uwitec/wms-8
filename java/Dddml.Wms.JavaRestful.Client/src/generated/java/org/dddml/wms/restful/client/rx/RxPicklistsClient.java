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
import org.dddml.wms.domain.partyrole.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.picklist.*;

public interface RxPicklistsClient {

    @Headers("Accept: application/json")
    @GET("Picklists")
    Observable<List<PicklistStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Picklists/_count")
    Observable<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Picklists/{picklistId}")
    Observable<PicklistStateDto> get(@Path("picklistId") String picklistId, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("Picklists/_metadata/filteringFields")
    Observable<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("Picklists/{picklistId}/_stateEvents/{version}")
    Observable<PicklistStateEventDto> getStateEvent(@Path("picklistId") String picklistId, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("Picklists/{picklistId}/_historyStates/{version}")
    Observable<PicklistStateDto> getHistoryState(@Path("picklistId") String picklistId, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("Picklists/{picklistId}/PicklistRoles/{partyRoleId}")
    Observable<PicklistRoleStateDto> getPicklistRole(@Path("picklistId") String picklistId, @Path("partyRoleId") String partyRoleId);
 
    @Headers("Accept: application/json")
    @GET("Picklists/{picklistId}/PicklistRoles")
    Observable<List<PicklistRoleStateDto>> getPicklistRoles(@Path("picklistId") String picklistId, @Query("sort") String sort, @Query("fields") String fields, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @PUT("Picklists/{picklistId}")
    Observable<String> put(@Path("picklistId") String picklistId, @Body CreateOrMergePatchPicklistDto.CreatePicklistDto value);

    @Headers("Accept: application/json")
    @POST("Picklists")
    Observable<String> post(@Body CreateOrMergePatchPicklistDto.CreatePicklistDto value);

    @Headers("Accept: application/json")
    @PATCH("Picklists/{picklistId}")
    Observable<String> patch(@Path("picklistId") String picklistId, @Body CreateOrMergePatchPicklistDto.MergePatchPicklistDto value);

    @Headers("Accept: application/json")
    @DELETE("Picklists/{picklistId}")
    Observable<String> delete(@Path("picklistId") String picklistId, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

