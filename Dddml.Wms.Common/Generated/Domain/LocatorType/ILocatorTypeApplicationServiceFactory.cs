﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLocatorTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.LocatorType;

namespace Dddml.Wms.Domain.LocatorType
{

    public partial interface ILocatorTypeApplicationServiceFactory
    {

        ILocatorTypeApplicationService LocatorTypeApplicationService { get; }

        ICreateLocatorType NewCreateLocatorType();

        IMergePatchLocatorType NewMergePatchLocatorType();

        IDeleteLocatorType NewDeleteLocatorType();
    }


}

