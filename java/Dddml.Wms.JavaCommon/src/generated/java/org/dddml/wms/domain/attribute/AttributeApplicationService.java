package org.dddml.wms.domain.attribute;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface AttributeApplicationService
{
    void when(AttributeCommand.CreateAttribute c);

    void when(AttributeCommand.MergePatchAttribute c);

    void when(AttributeCommand.DeleteAttribute c);

    AttributeState get(String id);

    Iterable<AttributeState> getAll(Integer firstResult, Integer maxResults);

    Iterable<AttributeState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<AttributeState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<AttributeState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    AttributeEvent getEvent(String attributeId, long version);

    AttributeState getHistoryState(String attributeId, long version);

    AttributeValueState getAttributeValue(String attributeId, String value);

    Iterable<AttributeValueState> getAttributeValues(String attributeId, Criterion filter, List<String> orders);

    AttributeAliasState getAttributeAlias(String attributeId, String code);

    Iterable<AttributeAliasState> getAttributeAlias(String attributeId, Criterion filter, List<String> orders);

}

