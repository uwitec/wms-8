﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{

	public static partial class InventoryItemEntryMvoStateDtoExtension
	{

        public static IInventoryItemEntryMvoCommand ToCreateOrMergePatchInventoryItemEntryMvo(this InventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchInventoryItemEntryMvo<CreateInventoryItemEntryMvoDto, MergePatchInventoryItemEntryMvoDto>();
        }

        public static DeleteInventoryItemEntryMvoDto ToDeleteInventoryItemEntryMvo(this InventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToDeleteInventoryItemEntryMvo<DeleteInventoryItemEntryMvoDto>();
        }

        public static MergePatchInventoryItemEntryMvoDto ToMergePatchInventoryItemEntryMvo(this InventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToMergePatchInventoryItemEntryMvo<MergePatchInventoryItemEntryMvoDto>();
        }

        public static CreateInventoryItemEntryMvoDto ToCreateInventoryItemEntryMvo(this InventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToCreateInventoryItemEntryMvo<CreateInventoryItemEntryMvoDto>();
        }
		

	}

}
