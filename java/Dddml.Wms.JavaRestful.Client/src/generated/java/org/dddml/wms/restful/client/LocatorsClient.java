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
import org.dddml.wms.domain.locator.*;

public interface LocatorsClient {

    @Headers("Accept: application/json")
    @GET("Locators")
    Call<List<LocatorStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Locators/_count")
    Call<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("Locators/{locatorId}")
    Call<LocatorStateDto> get(@Path("locatorId") String locatorId, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("Locators/_metadata/filteringFields")
    Call<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("Locators/{locatorId}/_stateEvents/{version}")
    Call<LocatorStateEventDto> getStateEvent(@Path("locatorId") String locatorId, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("Locators/{locatorId}/_historyStates/{version}")
    Call<LocatorStateDto> getHistoryState(@Path("locatorId") String locatorId, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("Locators/{locatorId}")
    Call<String> put(@Path("locatorId") String locatorId, @Body CreateOrMergePatchLocatorDto.CreateLocatorDto value);

    @Headers("Accept: application/json")
    @POST("Locators")
    Call<String> post(@Body CreateOrMergePatchLocatorDto.CreateLocatorDto value);

    @Headers("Accept: application/json")
    @PATCH("Locators/{locatorId}")
    Call<String> patch(@Path("locatorId") String locatorId, @Body CreateOrMergePatchLocatorDto.MergePatchLocatorDto value);

    @Headers("Accept: application/json")
    @DELETE("Locators/{locatorId}")
    Call<String> delete(@Path("locatorId") String locatorId, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

