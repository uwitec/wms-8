﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Attribute.NHibernate
{

	public class NHibernateAttributeAliasStateDao : IAttributeAliasStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "Code", "Name", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "AttributeId" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeAliasStateDao()
		{
		}

        [Transaction(ReadOnly = true)]
        public IAttributeAliasState Get(AttributeAliasId id, bool nullAllowed)
        {
            IAttributeAliasState state = CurrentSession.Get<AttributeAliasState>(id);
            if (!nullAllowed && state == null)
            {
                state = new AttributeAliasState();
                (state as AttributeAliasState).AttributeAliasId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeAliasState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IAttributeAliasState state)
        {
            IAttributeAliasState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeAliasState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IAttributeAliasState state)
        {
            IAttributeAliasState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeAliasState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeAliasState> FindByAttributeId(string attributeId)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeAliasState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("AttributeAliasId.AttributeId", attributeId))
                ;

            return criteria.Add(partIdCondition).List<AttributeAliasState>();
        }

    }

	
}
