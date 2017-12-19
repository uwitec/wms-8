﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InOut
{

	public partial interface IInOutApplicationService : IApplicationService
	{
		void When(ICreateInOut c);

		void When(IMergePatchInOut c);

		void When(IDeleteInOut c);

 		IInOutState Get(string documentNumber);

        IEnumerable<IInOutState> GetAll(int firstResult, int maxResults);

        IEnumerable<IInOutState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IInOutState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IInOutState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IInOutStateEvent GetStateEvent(string documentNumber, long version);

        IInOutState GetHistoryState(string documentNumber, long version);

        IInOutLineState GetInOutLine(string inOutDocumentNumber, long lineNumber);


	}

    public static partial class InOutApplicationServiceExtension
    {
        public static IEnumerable<IInOutState> GetByProperty(this IInOutApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IInOutState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IInOutState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IInOutState> GetByProperty<TPropertyType>(this IInOutApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IInOutState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IInOutState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

