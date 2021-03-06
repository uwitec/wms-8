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
import org.dddml.wms.domain.attributesetinstanceextensionfield.*;

public interface RxAttributeSetInstanceExtensionFieldsClient {

    @Headers("Accept: application/json")
    @GET("AttributeSetInstanceExtensionFields")
    Observable<List<AttributeSetInstanceExtensionFieldStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("AttributeSetInstanceExtensionFields/_count")
    Observable<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("AttributeSetInstanceExtensionFields/{name}")
    Observable<AttributeSetInstanceExtensionFieldStateDto> get(@Path("name") String name, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("AttributeSetInstanceExtensionFields/_metadata/filteringFields")
    Observable<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("AttributeSetInstanceExtensionFields/{name}/_stateEvents/{version}")
    Observable<AttributeSetInstanceExtensionFieldStateEventDto> getStateEvent(@Path("name") String name, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("AttributeSetInstanceExtensionFields/{name}/_historyStates/{version}")
    Observable<AttributeSetInstanceExtensionFieldStateDto> getHistoryState(@Path("name") String name, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("AttributeSetInstanceExtensionFields/{name}")
    Observable<String> put(@Path("name") String name, @Body CreateOrMergePatchAttributeSetInstanceExtensionFieldDto.CreateAttributeSetInstanceExtensionFieldDto value);

    @Headers("Accept: application/json")
    @POST("AttributeSetInstanceExtensionFields")
    Observable<String> post(@Body CreateOrMergePatchAttributeSetInstanceExtensionFieldDto.CreateAttributeSetInstanceExtensionFieldDto value);

    @Headers("Accept: application/json")
    @PATCH("AttributeSetInstanceExtensionFields/{name}")
    Observable<String> patch(@Path("name") String name, @Body CreateOrMergePatchAttributeSetInstanceExtensionFieldDto.MergePatchAttributeSetInstanceExtensionFieldDto value);

    @Headers("Accept: application/json")
    @DELETE("AttributeSetInstanceExtensionFields/{name}")
    Observable<String> delete(@Path("name") String name, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

