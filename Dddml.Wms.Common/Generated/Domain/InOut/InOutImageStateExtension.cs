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

	public static partial class InOutImageStateExtension
	{

        public static IInOutImageCommand ToCreateOrMergePatchInOutImage(this InOutImageState state)
        {
            return state.ToCreateOrMergePatchInOutImage<CreateInOutImage, MergePatchInOutImage>();
        }

        public static RemoveInOutImage ToRemoveInOutImage(this InOutImageState state)
        {
            return state.ToRemoveInOutImage<RemoveInOutImage>();
        }

        public static MergePatchInOutImage ToMergePatchInOutImage(this InOutImageState state)
        {
            return state.ToMergePatchInOutImage<MergePatchInOutImage>();
        }

        public static CreateInOutImage ToCreateInOutImage(this InOutImageState state)
        {
            return state.ToCreateInOutImage<CreateInOutImage>();
        }
		

	}

}

