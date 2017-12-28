﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

	public class MovementConfirmationLineIdDtoWrapper : MovementConfirmationLineIdDto
	{

        private MovementConfirmationLineId _value = new MovementConfirmationLineId();

		public MovementConfirmationLineIdDtoWrapper()
		{
		}

		public MovementConfirmationLineIdDtoWrapper(MovementConfirmationLineId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override MovementConfirmationLineId ToMovementConfirmationLineId()
        {
            return this._value;
        }

		public override string MovementConfirmationDocumentNumber { 
			get { return _value.MovementConfirmationDocumentNumber; } 
			set { _value.MovementConfirmationDocumentNumber = value; } 
		}

		public override string LineNumber { 
			get { return _value.LineNumber; } 
			set { _value.LineNumber = value; } 
		}


	}

}

