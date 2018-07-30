package org.dddml.wms.domain.shipment.hibernate;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.shipment.*;
import org.dddml.wms.specialization.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernateShipmentImageEventDao implements ShipmentImageEventDao
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    @Override
    public void save(ShipmentImageEvent e)
    {
        getCurrentSession().save(e);
        if (e instanceof Saveable)
        {
            Saveable saveable = (Saveable) e;
            saveable.save();
        }
    }


    @Transactional(readOnly = true)
    @Override
    public Iterable<ShipmentImageEvent> findByShipmentEventId(ShipmentEventId shipmentEventId)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractShipmentImageEvent.class);
        Junction partIdCondition = Restrictions.conjunction()
            .add(Restrictions.eq("shipmentImageEventId.shipmentId", shipmentEventId.getShipmentId()))
            .add(Restrictions.eq("shipmentImageEventId.shipmentVersion", shipmentEventId.getVersion()))
            ;
        return criteria.add(partIdCondition).list();
    }

}

