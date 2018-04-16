﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomConversionDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomConversion;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.UomConversion
{

	public partial interface IUomConversionApplicationService : IApplicationService
	{
		void When(ICreateUomConversion c);

		void When(IMergePatchUomConversion c);

		void When(IDeleteUomConversion c);

 		IUomConversionState Get(UomConversionId uomConversionId);

        IEnumerable<IUomConversionState> GetAll(int firstResult, int maxResults);

        IEnumerable<IUomConversionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IUomConversionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IUomConversionState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IUomConversionEvent GetEvent(UomConversionId uomConversionId, long version);

        IUomConversionState GetHistoryState(UomConversionId uomConversionId, long version);


	}

    public static partial class UomConversionApplicationServiceExtension
    {
        public static IEnumerable<IUomConversionState> GetByProperty(this IUomConversionApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IUomConversionState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IUomConversionState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IUomConversionState> GetByProperty<TPropertyType>(this IUomConversionApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IUomConversionState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IUomConversionState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

