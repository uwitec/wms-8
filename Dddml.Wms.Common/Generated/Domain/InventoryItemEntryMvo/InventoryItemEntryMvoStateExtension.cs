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

	public static partial class InventoryItemEntryMvoStateExtension
	{

        public static IInventoryItemEntryMvoCommand ToCreateOrMergePatchInventoryItemEntryMvo(this InventoryItemEntryMvoState state)
        {
            return state.ToCreateOrMergePatchInventoryItemEntryMvo<CreateInventoryItemEntryMvo, MergePatchInventoryItemEntryMvo>();
        }

        public static DeleteInventoryItemEntryMvo ToDeleteInventoryItemEntryMvo(this InventoryItemEntryMvoState state)
        {
            return state.ToDeleteInventoryItemEntryMvo<DeleteInventoryItemEntryMvo>();
        }

        public static MergePatchInventoryItemEntryMvo ToMergePatchInventoryItemEntryMvo(this InventoryItemEntryMvoState state)
        {
            return state.ToMergePatchInventoryItemEntryMvo<MergePatchInventoryItemEntryMvo>();
        }

        public static CreateInventoryItemEntryMvo ToCreateInventoryItemEntryMvo(this InventoryItemEntryMvoState state)
        {
            return state.ToCreateInventoryItemEntryMvo<CreateInventoryItemEntryMvo>();
        }
		

	}

}

