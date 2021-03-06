﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementType;

namespace Dddml.Wms.Domain.MovementType
{

    public partial class MovementTypeApplicationServiceFactory : IMovementTypeApplicationServiceFactory
    {

        public virtual IMovementTypeApplicationService MovementTypeApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["MovementTypeApplicationService"] as IMovementTypeApplicationService;
		    }
        }

        public virtual ICreateMovementType NewCreateMovementType()
        {
		    return new CreateMovementType();
        }

        public virtual IMergePatchMovementType NewMergePatchMovementType()
        {
            return new MergePatchMovementType();
        }

        public virtual IDeleteMovementType NewDeleteMovementType()
        {
            return new DeleteMovementType();
        }

    }


}

