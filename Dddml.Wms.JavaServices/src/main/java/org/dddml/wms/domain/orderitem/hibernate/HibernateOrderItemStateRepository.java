package org.dddml.wms.domain.orderitem.hibernate;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.hibernate.Session;
import org.hibernate.Criteria;
import org.hibernate.criterion.Order;
import org.hibernate.criterion.Criterion;
import org.hibernate.criterion.Projections;
import org.hibernate.SessionFactory;
import org.dddml.wms.domain.orderitem.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernateOrderItemStateRepository implements OrderItemStateRepository
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }
    
    private static final Set<String> readOnlyPropertyPascalCaseNames = new HashSet<String>(Arrays.asList("OrderItemId", "ProductId", "ExternalProductId", "Quantity", "CancelQuantity", "SelectedAmount", "ExternalId", "OrderItemTypeId", "OrderItemGroupSeqId", "IsItemGroupPrimary", "FromInventoryItemId", "IsPromo", "QuoteId", "QuoteItemSeqId", "ShoppingListId", "ShoppingListItemSeqId", "UnitPrice", "UnitListPrice", "UnitAverageCost", "UnitRecurringPrice", "IsModifiedPrice", "RecurringFreqUomId", "ItemDescription", "Comments", "CorrespondingPoId", "StatusId", "SyncStatusId", "EstimatedShipDate", "EstimatedDeliveryDate", "AutoCancelDate", "DontCancelSetDate", "DontCancelSetBy", "ShipBeforeDate", "ShipAfterDate", "CancelBackOrderDate", "OverrideGlAccountId", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted"));
    
    private ReadOnlyProxyGenerator readOnlyProxyGenerator;
    
    public ReadOnlyProxyGenerator getReadOnlyProxyGenerator() {
        return readOnlyProxyGenerator;
    }

    public void setReadOnlyProxyGenerator(ReadOnlyProxyGenerator readOnlyProxyGenerator) {
        this.readOnlyProxyGenerator = readOnlyProxyGenerator;
    }

    @Transactional(readOnly = true)
    public OrderItemState get(OrderItemId id, boolean nullAllowed) {
        OrderItemState state = (OrderItemState)getCurrentSession().get(AbstractOrderItemState.SimpleOrderItemState.class, id);
        if (!nullAllowed && state == null) {
            state = new AbstractOrderItemState.SimpleOrderItemState();
            state.setOrderItemId(id);
        }
        if (getReadOnlyProxyGenerator() != null && state != null) {
            return (OrderItemState) getReadOnlyProxyGenerator().createProxy(state, new Class[]{OrderItemState.class}, "getStateReadOnly", readOnlyPropertyPascalCaseNames);
        }
        return state;
    }

    public void save(OrderItemState state)
    {
        OrderItemState s = state;
        if (getReadOnlyProxyGenerator() != null) {
            s = (OrderItemState) getReadOnlyProxyGenerator().getTarget(state);
        }
        if(s.getVersion() == null) {
            getCurrentSession().save(s);
        }else {
            getCurrentSession().update(s);
        }

        if (s instanceof Saveable)
        {
            Saveable saveable = (Saveable) s;
            saveable.save();
        }
    }

    //protected static void addNotDeletedRestriction(Criteria criteria) {
    //    criteria.add(org.hibernate.criterion.Restrictions.eq("deleted", false));
    //}

}

