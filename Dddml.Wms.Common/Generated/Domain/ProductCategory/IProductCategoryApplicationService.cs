﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ProductCategory
{

	public partial interface IProductCategoryApplicationService : IApplicationService
	{
		void When(ICreateProductCategory c);

		void When(IMergePatchProductCategory c);

		void When(IDeleteProductCategory c);

 		IProductCategoryState Get(string productCategoryId);

        IEnumerable<IProductCategoryState> GetAll(int firstResult, int maxResults);

        IEnumerable<IProductCategoryState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IProductCategoryState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IProductCategoryState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IProductCategoryStateEvent GetStateEvent(string productCategoryId, long version);

        IProductCategoryState GetHistoryState(string productCategoryId, long version);

        IEnumerable<IProductCategoryState> GetProductCategoryIdToProductCategories(string productCategoryId);


	}

    public static partial class ProductCategoryApplicationServiceExtension
    {
        public static IEnumerable<IProductCategoryState> GetByProperty(this IProductCategoryApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IProductCategoryState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IProductCategoryState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IProductCategoryState> GetByProperty<TPropertyType>(this IProductCategoryApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IProductCategoryState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IProductCategoryState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

