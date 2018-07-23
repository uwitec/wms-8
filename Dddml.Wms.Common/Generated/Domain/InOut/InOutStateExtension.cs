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

	public static partial class InOutStateExtension
	{

        public static IInOutCommand ToCreateOrMergePatchInOut(this InOutState state)
        {
            return state.ToCreateOrMergePatchInOut<CreateInOut, MergePatchInOut, CreateInOutImage, MergePatchInOutImage, CreateInOutLine, MergePatchInOutLine, CreateInOutLineImage, MergePatchInOutLineImage>();
        }

        public static DeleteInOut ToDeleteInOut(this InOutState state)
        {
            return state.ToDeleteInOut<DeleteInOut>();
        }

        public static MergePatchInOut ToMergePatchInOut(this InOutState state)
        {
            return state.ToMergePatchInOut<MergePatchInOut, CreateInOutImage, MergePatchInOutImage, CreateInOutLine, MergePatchInOutLine, CreateInOutLineImage, MergePatchInOutLineImage>();
        }

        public static CreateInOut ToCreateInOut(this InOutState state)
        {
            return state.ToCreateInOut<CreateInOut, CreateInOutImage, CreateInOutLine, CreateInOutLineImage>();
        }
		

	}

}

