package org.dddml.wms.domain.hibernate;

import java.util.*;
import java.util.Date;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class HibernateUserClaimMvoStateRepository implements UserClaimMvoStateRepository
{
    public SessionFactory sessionFactory;

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }
    
    //[Transaction (ReadOnly = true)]
    public UserClaimMvoState get(UserClaimId id)
    {
        UserClaimMvoState state = (UserClaimMvoState)getCurrentSession().get(AbstractUserClaimMvoState.SimpleUserClaimMvoState.class, id);
        if (state == null) {
            state = new AbstractUserClaimMvoState.SimpleUserClaimMvoState();
            state.setUserClaimId(id);
        }
        return state;
    }

    //[Transaction(ReadOnly = true)]
    public Iterable<UserClaimMvoState> getAll(Integer firstResult, Integer maxResults)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractUserClaimMvoState.SimpleUserClaimMvoState.class);
        criteria.setFirstResult(firstResult);
        criteria.setMaxResults(maxResults);
         //AddNotDeletedRestriction(criteria);//todo
        return criteria.list();
    }

    //[Transaction]
    public void save(UserClaimMvoState state)
    {
        getCurrentSession().saveOrUpdate(state);

        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
    }

    public Iterable<UserClaimMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults)
    { throw new UnsupportedOperationException(); }//todo

    //Iterable<UserClaimMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    public UserClaimMvoState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders)
    { throw new UnsupportedOperationException(); }//todo

    public UserClaimMvoState getFirst(Map.Entry<String, Object> keyValue, List<String> orders)
    { throw new UnsupportedOperationException(); }//todo

    public Iterable<UserClaimMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults)
    { throw new UnsupportedOperationException(); }//todo

    public long getCount(Iterable<Map.Entry<String, Object>> filter)
    { throw new UnsupportedOperationException(); }//todo

    //long getCount(Criterion filter);

/*
        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserClaimMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserClaimMvoState>();

            CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserClaimMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserClaimMvoState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserClaimMvoState>();

            CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserClaimMvoState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IUserClaimMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<UserClaimMvoState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserClaimMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserClaimMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserClaimMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserClaimMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            if (filter != null)
            {
                HibernateICriterion hc = CriterionUtils.ToHibernateCriterion(filter);
                criteria.Add(hc);
            }
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
            criteria.Add(HibernateRestrictions.Eq("Deleted", false));
        }

        protected void CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(ICriteria criteria, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult, int maxResults)
        {
            if (filter != null)
            {
                CriteriaAddFilter(criteria, filter);
            }
            CriteriaAddOrdersAndSetFirstResultAndMaxResults(criteria, orders, firstResult, maxResults);
        }

        protected void CriteriaAddFilter(ICriteria criteria, IEnumerable<KeyValuePair<string, object>> filter)
        {
            foreach (KeyValuePair<string, object> p in filter)
            {
                CriteriaAddFilterPair(criteria, p);
            }
        }

        protected void CriteriaAddFilterPair(ICriteria criteria, KeyValuePair<string, object> filterPair)
        {
            if (filterPair.Value == null)
            {
                criteria.Add(HibernateRestrictions.IsNull(filterPair.Key));
            }
            else
            {
                criteria.Add(HibernateRestrictions.Eq(filterPair.Key, filterPair.Value));
            }
        }

        protected static void CriteriaAddOrders(ICriteria criteria, IList<string> orders)
        {
            foreach (var order in orders)
            {
                bool isDesc = order.StartsWith("-");
                var pName = isDesc ? order.Substring(1) : order;
                criteria.AddOrder(isDesc ? Order.Desc(pName) : Order.Asc(pName));
            }
        }

        protected void DisjunctionAddCriterion(HibernateDisjunction disjunction, string propertyName, object propertyValue)
        {
            if (propertyValue == null)
            {
                disjunction.Add(HibernateRestrictions.IsNull(propertyName));
            }
            else
            {
                disjunction.Add(HibernateRestrictions.Eq(propertyName, propertyValue));
            }
        }

        protected void CriteriaAddCriterion(ICriteria criteria, string propertyName, object propertyValue)
        {
            if (propertyValue == null)
            {
                criteria.Add(HibernateRestrictions.IsNull(propertyName));
            }
            else
            {
                criteria.Add(HibernateRestrictions.Eq(propertyName, propertyValue));
            }
        }

        private static void CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(ICriteria criteria, Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult, int maxResults)
        {
            CriteriaAddFilterAndSetFirstResultAndMaxResults(criteria, filter, firstResult, maxResults);
            if (orders != null)
            {
                CriteriaAddOrders(criteria, orders);
            }
        }
		
        private static void CriteriaAddOrdersAndSetFirstResultAndMaxResults(ICriteria criteria, IList<string> orders, int firstResult, int maxResults)
        {
            if (orders != null)
            {
                CriteriaAddOrders(criteria, orders);
            }

            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
        }

        private static void CriteriaAddFilterAndSetFirstResultAndMaxResults(ICriteria criteria, Dddml.Support.Criterion.ICriterion filter, int firstResult, int maxResults)
        {
            if (filter != null)
            {
                HibernateICriterion hc = CriterionUtils.ToHibernateCriterion(filter);
                criteria.Add(hc);
            }
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
        }
*/

}
