﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPostingRuleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryPostingRule
{

    public partial interface IInventoryPostingRuleApplicationServiceFactory
    {

        IInventoryPostingRuleApplicationService InventoryPostingRuleApplicationService { get; }

        ICreateInventoryPostingRule NewCreateInventoryPostingRule();

        IMergePatchInventoryPostingRule NewMergePatchInventoryPostingRule();

        IDeleteInventoryPostingRule NewDeleteInventoryPostingRule();
    }


}

