﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePickwaveDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Pickwave;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Pickwave
{
	public partial interface IPickwaveStateRepository
	{

        IPickwaveState Get(long? id, bool nullAllowed);
        
        void Save(IPickwaveState state);
        
	}

}

