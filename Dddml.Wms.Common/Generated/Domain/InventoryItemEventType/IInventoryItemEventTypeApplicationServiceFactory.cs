﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEventTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEventType;

namespace Dddml.Wms.Domain.InventoryItemEventType
{

    public partial interface IInventoryItemEventTypeApplicationServiceFactory
    {

        IInventoryItemEventTypeApplicationService InventoryItemEventTypeApplicationService { get; }

        ICreateInventoryItemEventType NewCreateInventoryItemEventType();

        IMergePatchInventoryItemEventType NewMergePatchInventoryItemEventType();

        IDeleteInventoryItemEventType NewDeleteInventoryItemEventType();
    }


}

