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

	public static partial class DayPlanStateDtoExtensions
	{

        public static IDayPlanCommand ToCreateOrMergePatchDayPlan(this DayPlanStateDto state)
        {
            return state.ToCreateOrMergePatchDayPlan<CreateDayPlanDto, MergePatchDayPlanDto>();
        }

        public static RemoveDayPlanDto ToRemoveDayPlan(this DayPlanStateDto state)
        {
            return state.ToRemoveDayPlan<RemoveDayPlanDto>();
        }

        public static MergePatchDayPlanDto ToMergePatchDayPlan(this DayPlanStateDto state)
        {
            return state.ToMergePatchDayPlan<MergePatchDayPlanDto>();
        }

        public static CreateDayPlanDto ToCreateDayPlan(this DayPlanStateDto state)
        {
            return state.ToCreateDayPlan<CreateDayPlanDto>();
        }
		

	}

}
