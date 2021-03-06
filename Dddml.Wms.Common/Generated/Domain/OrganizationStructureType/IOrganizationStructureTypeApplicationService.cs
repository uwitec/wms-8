﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructureType;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrganizationStructureType
{

	public partial interface IOrganizationStructureTypeApplicationService : IApplicationService
	{
		void When(ICreateOrganizationStructureType c);

		void When(IMergePatchOrganizationStructureType c);

		void When(IDeleteOrganizationStructureType c);

 		IOrganizationStructureTypeState Get(string id);

        IEnumerable<IOrganizationStructureTypeState> GetAll(int firstResult, int maxResults);

        IEnumerable<IOrganizationStructureTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrganizationStructureTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrganizationStructureTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IOrganizationStructureTypeEvent GetEvent(string id, long version);

        IOrganizationStructureTypeState GetHistoryState(string id, long version);


	}

    public static partial class OrganizationStructureTypeApplicationServiceExtension
    {
        public static IEnumerable<IOrganizationStructureTypeState> GetByProperty(this IOrganizationStructureTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrganizationStructureTypeState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrganizationStructureTypeState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IOrganizationStructureTypeState> GetByProperty<TPropertyType>(this IOrganizationStructureTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrganizationStructureTypeState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrganizationStructureTypeState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

