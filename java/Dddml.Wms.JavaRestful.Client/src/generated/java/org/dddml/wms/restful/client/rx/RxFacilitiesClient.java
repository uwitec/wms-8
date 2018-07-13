package org.dddml.wms.restful.client.rx;

import java.util.List;

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
import org.dddml.wms.domain.facility.*;

public interface RxFacilitiesClient {

    @Headers("Accept: application/json")
    @GET("Facilities")
    Observable<List<FacilityStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Facilities/_count")
    Observable<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Facilities/{id}")
    Observable<FacilityStateDto> get(@Path("id") String id, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("Facilities/_metadata/filteringFields")
    Observable<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("Facilities/{id}/_stateEvents/{version}")
    Observable<FacilityStateEventDto> getStateEvent(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("Facilities/{id}/_historyStates/{version}")
    Observable<FacilityStateDto> getHistoryState(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("Facilities/{id}")
    Observable<String> put(@Path("id") String id, @Body CreateOrMergePatchFacilityDto.CreateFacilityDto value);

    @Headers("Accept: application/json")
    @POST("Facilities")
    Observable<String> post(@Body CreateOrMergePatchFacilityDto.CreateFacilityDto value);

    @Headers("Accept: application/json")
    @PATCH("Facilities/{id}")
    Observable<String> patch(@Path("id") String id, @Body CreateOrMergePatchFacilityDto.MergePatchFacilityDto value);

    @Headers("Accept: application/json")
    @DELETE("Facilities/{id}")
    Observable<String> delete(@Path("id") String id, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

