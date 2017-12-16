﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;

namespace Dddml.Wms.Domain.StatusItem
{

    public partial class StatusItemApplicationServiceFactory : IStatusItemApplicationServiceFactory
    {

        public virtual IStatusItemApplicationService StatusItemApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["StatusItemApplicationService"] as IStatusItemApplicationService;
		    }
        }

        public virtual ICreateStatusItem NewCreateStatusItem()
        {
		    return new CreateStatusItem();
        }

        public virtual IMergePatchStatusItem NewMergePatchStatusItem()
        {
            return new MergePatchStatusItem();
        }

        public virtual IDeleteStatusItem NewDeleteStatusItem()
        {
            return new DeleteStatusItem();
        }

    }


}

