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
import retrofit2.http.Path;
import retrofit2.http.Query;
import rx.Observable;

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.damagetype.*;

public interface RxDamageTypesClient {

    @Headers("Accept: application/json")
    @GET("DamageTypes")
    Observable<List<DamageTypeStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("DamageTypes/_count")
    Observable<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("DamageTypes/{id}")
    Observable<DamageTypeStateDto> get(@Path("id") String id, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("DamageTypes/_metadata/filteringFields")
    Observable<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("DamageTypes/{id}/_historyStates/{version}")
    Observable<DamageTypeStateDto> getHistoryState(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("DamageTypes/{id}")
    Observable<String> put(@Path("id") String id, @Body CreateOrMergePatchDamageTypeDto.CreateDamageTypeDto value);

    @Headers("Accept: application/json")
    @PATCH("DamageTypes/{id}")
    Observable<String> patch(@Path("id") String id, @Body CreateOrMergePatchDamageTypeDto.MergePatchDamageTypeDto value);

    @Headers("Accept: application/json")
    @DELETE("DamageTypes/{id}")
    Observable<String> delete(@Path("id") String id, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}
