﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRejectionReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RejectionReason;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.RejectionReason
{
	public partial interface IRejectionReasonStateRepository
	{

        IRejectionReasonState Get(string id, bool nullAllowed);
        
        void Save(IRejectionReasonState state);
        
	}

}
