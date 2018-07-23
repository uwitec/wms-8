﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public static partial class InOutImageStateDtoExtension
	{

        public static IInOutImageCommand ToCreateOrMergePatchInOutImage(this InOutImageStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchInOutImage<CreateInOutImageDto, MergePatchInOutImageDto>();
        }

        public static RemoveInOutImageDto ToRemoveInOutImage(this InOutImageStateDtoWrapper state)
        {
            return state.ToRemoveInOutImage<RemoveInOutImageDto>();
        }

        public static MergePatchInOutImageDto ToMergePatchInOutImage(this InOutImageStateDtoWrapper state)
        {
            return state.ToMergePatchInOutImage<MergePatchInOutImageDto>();
        }

        public static CreateInOutImageDto ToCreateInOutImage(this InOutImageStateDtoWrapper state)
        {
            return state.ToCreateInOutImage<CreateInOutImageDto>();
        }
		

	}

}

