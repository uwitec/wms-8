package org.dddml.wms.domain.attributesetinstanceextensionfield.hibernate;

import java.io.Serializable;
import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.attributesetinstanceextensionfield.*;

public class HibernateAttributeSetInstanceExtensionFieldEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new AttributeSetInstanceExtensionFieldEventId((String) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedStateEventType()
    {
        return AbstractAttributeSetInstanceExtensionFieldStateEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractAttributeSetInstanceExtensionFieldStateEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        String idObj = (String) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractAttributeSetInstanceExtensionFieldStateEvent.class);
        criteria.add(Restrictions.eq("attributeSetInstanceExtensionFieldEventId.name", idObj));
        criteria.add(Restrictions.le("attributeSetInstanceExtensionFieldEventId.version", version));
        criteria.addOrder(Order.asc("attributeSetInstanceExtensionFieldEventId.version"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractAttributeSetInstanceExtensionFieldStateEvent) e).setStateEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractAttributeSetInstanceExtensionFieldStateEvent) es.get(es.size() - 1)).getAttributeSetInstanceExtensionFieldEventId().getVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

