﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateFacilityDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Facility;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Facility
{
	public partial interface IFacilityStateRepository
	{

        IFacilityState Get(string id, bool nullAllowed);
        
        void Save(IFacilityState state);
        
	}

}

