﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomType;

namespace Dddml.Wms.Domain.UomType
{

    public partial interface IUomTypeApplicationServiceFactory
    {

        IUomTypeApplicationService UomTypeApplicationService { get; }

        ICreateUomType NewCreateUomType();

        IMergePatchUomType NewMergePatchUomType();

        IDeleteUomType NewDeleteUomType();
    }


}

