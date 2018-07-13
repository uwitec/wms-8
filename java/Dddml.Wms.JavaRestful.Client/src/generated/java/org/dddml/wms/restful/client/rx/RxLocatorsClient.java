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
import org.dddml.wms.domain.locator.*;

public interface RxLocatorsClient {

    @Headers("Accept: application/json")
    @GET("Locators")
    Observable<List<LocatorStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Locators/_count")
    Observable<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Locators/{id}")
    Observable<LocatorStateDto> get(@Path("id") String id, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("Locators/_metadata/filteringFields")
    Observable<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("Locators/{id}/_stateEvents/{version}")
    Observable<LocatorStateEventDto> getStateEvent(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("Locators/{id}/_historyStates/{version}")
    Observable<LocatorStateDto> getHistoryState(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("Locators/{id}")
    Observable<String> put(@Path("id") String id, @Body CreateOrMergePatchLocatorDto.CreateLocatorDto value);

    @Headers("Accept: application/json")
    @POST("Locators")
    Observable<String> post(@Body CreateOrMergePatchLocatorDto.CreateLocatorDto value);

    @Headers("Accept: application/json")
    @PATCH("Locators/{id}")
    Observable<String> patch(@Path("id") String id, @Body CreateOrMergePatchLocatorDto.MergePatchLocatorDto value);

    @Headers("Accept: application/json")
    @DELETE("Locators/{id}")
    Observable<String> delete(@Path("id") String id, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

