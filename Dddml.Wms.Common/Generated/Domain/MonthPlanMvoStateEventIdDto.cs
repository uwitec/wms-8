﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public class MonthPlanMvoStateEventIdDto
	{

        private MonthPlanMvoStateEventId _value = new MonthPlanMvoStateEventId();

		public MonthPlanMvoStateEventIdDto()
		{
		}

		public MonthPlanMvoStateEventIdDto(MonthPlanMvoStateEventId val)
		{
			this._value = val;
		}

        public MonthPlanMvoStateEventId ToMonthPlanMvoStateEventId()
        {
            return this._value;
        }

		public virtual MonthPlanIdDto MonthPlanId { 
			get { return new MonthPlanIdDto(_value.MonthPlanId); } 
			set { _value.MonthPlanId = value.ToMonthPlanId(); } 
		}

		public virtual long PersonVersion { 
			get { return _value.PersonVersion; } 
			set { _value.PersonVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			MonthPlanMvoStateEventIdDto other = obj as MonthPlanMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

}

