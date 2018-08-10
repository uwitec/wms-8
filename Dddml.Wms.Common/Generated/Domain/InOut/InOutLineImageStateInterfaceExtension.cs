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

	public static partial class InOutLineImageStateInterfaceExtension
	{

        public static IInOutLineImageCommand ToCreateOrMergePatchInOutLineImage<TCreateInOutLineImage, TMergePatchInOutLineImage>(this IInOutLineImageState state)
            where TCreateInOutLineImage : ICreateInOutLineImage, new()
            where TMergePatchInOutLineImage : IMergePatchInOutLineImage, new()
        {
            bool bUnsaved = ((IInOutLineImageState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateInOutLineImage<TCreateInOutLineImage>();
            }
            else 
            {
                return state.ToMergePatchInOutLineImage<TMergePatchInOutLineImage>();
            }
        }

        public static TRemoveInOutLineImage ToRemoveInOutLineImage<TRemoveInOutLineImage>(this IInOutLineImageState state)
            where TRemoveInOutLineImage : IRemoveInOutLineImage, new()
        {
            var cmd = new TRemoveInOutLineImage();
            cmd.SequenceId = state.SequenceId;
            return cmd;
        }

        public static TMergePatchInOutLineImage ToMergePatchInOutLineImage<TMergePatchInOutLineImage>(this IInOutLineImageState state)
            where TMergePatchInOutLineImage : IMergePatchInOutLineImage, new()
        {
            var cmd = new TMergePatchInOutLineImage();

            cmd.SequenceId = state.SequenceId;
            cmd.Url = state.Url;
            cmd.Active = ((IInOutLineImageStateProperties)state).Active;
            cmd.InOutDocumentNumber = state.InOutDocumentNumber;
            cmd.InOutLineLineNumber = state.InOutLineLineNumber;
            
            if (state.Url == null) { cmd.IsPropertyUrlRemoved = true; }
            return cmd;
        }

        public static TCreateInOutLineImage ToCreateInOutLineImage<TCreateInOutLineImage>(this IInOutLineImageState state)
            where TCreateInOutLineImage : ICreateInOutLineImage, new()
        {
            var cmd = new TCreateInOutLineImage();

            cmd.SequenceId = state.SequenceId;
            cmd.Url = state.Url;
            cmd.Active = ((IInOutLineImageStateProperties)state).Active;
            cmd.InOutDocumentNumber = state.InOutDocumentNumber;
            cmd.InOutLineLineNumber = state.InOutLineLineNumber;
            return cmd;
        }
		

	}

}
