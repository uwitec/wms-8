﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructureType;

namespace Dddml.Wms.Domain.OrganizationStructureType
{

    public partial class OrganizationStructureTypeApplicationServiceFactory : IOrganizationStructureTypeApplicationServiceFactory
    {

        public virtual IOrganizationStructureTypeApplicationService OrganizationStructureTypeApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["OrganizationStructureTypeApplicationService"] as IOrganizationStructureTypeApplicationService;
		    }
        }

        public virtual ICreateOrganizationStructureType NewCreateOrganizationStructureType()
        {
		    return new CreateOrganizationStructureType();
        }

        public virtual IMergePatchOrganizationStructureType NewMergePatchOrganizationStructureType()
        {
            return new MergePatchOrganizationStructureType();
        }

        public virtual IDeleteOrganizationStructureType NewDeleteOrganizationStructureType()
        {
            return new DeleteOrganizationStructureType();
        }

    }


}
