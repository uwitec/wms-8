﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;

namespace Dddml.Wms.Domain.ProductCategory
{

    public partial interface IProductCategoryApplicationServiceFactory
    {

        IProductCategoryApplicationService ProductCategoryApplicationService { get; }

        ICreateProductCategory NewCreateProductCategory();

        IMergePatchProductCategory NewMergePatchProductCategory();

        IDeleteProductCategory NewDeleteProductCategory();
    }


}

