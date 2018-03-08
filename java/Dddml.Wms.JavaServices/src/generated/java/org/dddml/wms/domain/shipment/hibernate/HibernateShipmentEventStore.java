package org.dddml.wms.domain.shipment.hibernate;

import java.io.Serializable;
import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.shipment.*;

public class HibernateShipmentEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new ShipmentEventId((String) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedStateEventType()
    {
        return AbstractShipmentStateEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractShipmentStateEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        String idObj = (String) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractShipmentStateEvent.class);
        criteria.add(Restrictions.eq("shipmentEventId.shipmentId", idObj));
        criteria.add(Restrictions.le("shipmentEventId.version", version));
        criteria.addOrder(Order.asc("shipmentEventId.version"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractShipmentStateEvent) e).setStateEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractShipmentStateEvent) es.get(es.size() - 1)).getShipmentEventId().getVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

