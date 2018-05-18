package org.dddml.wms.restful.client;

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

import org.dddml.support.criterion.*;
import org.dddml.wms.domain.movementconfirmation.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.movementconfirmationlinemvo.*;

public interface MovementConfirmationLineMvosClient {

    @Headers("Accept: application/json")
    @GET("MovementConfirmationLineMvos")
    Call<List<MovementConfirmationLineMvoStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("MovementConfirmationLineMvos/_count")
    Call<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("MovementConfirmationLineMvos/{id}")
    Call<MovementConfirmationLineMvoStateDto> get(@Path("id") String id, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("MovementConfirmationLineMvos/_metadata/filteringFields")
    Call<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("MovementConfirmationLineMvos/{id}/_stateEvents/{version}")
    Call<MovementConfirmationLineMvoStateEventDto> getStateEvent(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("MovementConfirmationLineMvos/{id}/_historyStates/{version}")
    Call<MovementConfirmationLineMvoStateDto> getHistoryState(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @PUT("MovementConfirmationLineMvos/{id}")
    Call<String> put(@Path("id") String id, @Body CreateOrMergePatchMovementConfirmationLineMvoDto.CreateMovementConfirmationLineMvoDto value);

    @Headers("Accept: application/json")
    @PATCH("MovementConfirmationLineMvos/{id}")
    Call<String> patch(@Path("id") String id, @Body CreateOrMergePatchMovementConfirmationLineMvoDto.MergePatchMovementConfirmationLineMvoDto value);

    @Headers("Accept: application/json")
    @DELETE("MovementConfirmationLineMvos/{id}")
    Call<String> delete(@Path("id") String id, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}
