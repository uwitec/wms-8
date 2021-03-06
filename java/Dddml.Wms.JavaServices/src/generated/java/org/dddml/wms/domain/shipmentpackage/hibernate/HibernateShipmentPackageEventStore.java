package org.dddml.wms.domain.shipmentpackage.hibernate;

import java.io.Serializable;
import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.shipmentpackage.*;

public class HibernateShipmentPackageEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new ShipmentPackageEventId((ShipmentPackageId) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedEventType()
    {
        return AbstractShipmentPackageEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractShipmentPackageEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        ShipmentPackageId idObj = (ShipmentPackageId) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractShipmentPackageEvent.class);
        criteria.add(Restrictions.eq("shipmentPackageEventId.shipmentPackageIdShipmentId", idObj.getShipmentId()));
        criteria.add(Restrictions.eq("shipmentPackageEventId.shipmentPackageIdShipmentPackageSeqId", idObj.getShipmentPackageSeqId()));
        criteria.add(Restrictions.le("shipmentPackageEventId.version", version));
        criteria.addOrder(Order.asc("shipmentPackageEventId.version"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractShipmentPackageEvent) e).setEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractShipmentPackageEvent) es.get(es.size() - 1)).getShipmentPackageEventId().getVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

