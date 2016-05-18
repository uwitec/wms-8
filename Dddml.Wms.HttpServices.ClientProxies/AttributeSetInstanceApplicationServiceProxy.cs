﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;

namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class AttributeSetInstanceApplicationServiceProxy : IAttributeSetInstanceApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public AttributeSetInstanceApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeSetInstanceApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateAttributeSetInstanceDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as ICreateAttributeSetInstance).AttributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstancePutRequest(uriParameters, (CreateAttributeSetInstanceDto)c);
                
            var resp = _ramlClient.AttributeSetInstance.Put(req).GetAwaiter().GetResult();;
            //};
            //act();
        }

        public void When(MergePatchAttributeSetInstanceDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IMergePatchAttributeSetInstance).AttributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstancePatchRequest(uriParameters, (MergePatchAttributeSetInstanceDto)c);
            var resp = _ramlClient.AttributeSetInstance.Patch(req).GetAwaiter().GetResult();;
            //};
            //act();
        }

        public void When(DeleteAttributeSetInstanceDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeleteAttributeSetInstance).AttributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeSetInstanceDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new AttributeSetInstanceDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.AttributeSetInstance.Delete(req).GetAwaiter().GetResult();;
            //};
            //act();
        }
		
        void IAttributeSetInstanceApplicationService.When(ICreateAttributeSetInstance c)
        {
            this.When((CreateAttributeSetInstanceDto)c);
        }

        void IAttributeSetInstanceApplicationService.When(IMergePatchAttributeSetInstance c)
        {
            this.When((MergePatchAttributeSetInstanceDto)c);
        }

        void IAttributeSetInstanceApplicationService.When(IDeleteAttributeSetInstance c)
        {
            this.When((DeleteAttributeSetInstanceDto)c);
        }

        public IAttributeSetInstanceState Get(string attributeSetInstanceId)
        {
            IAttributeSetInstanceState state = null;
            //Action act = async () =>
            //{
            var idObj = (attributeSetInstanceId);
            var uriParameters = new AttributeSetInstanceUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceGetRequest(uriParameters);

            var resp = _ramlClient.AttributeSetInstance.Get(req).GetAwaiter().GetResult();
            state = resp.Content;
            //};
            //act();
            return state;
        }

        public IEnumerable<IAttributeSetInstanceState> GetAll(int firstResult, int maxResults)
        {
            IEnumerable<IAttributeSetInstanceState> states = null;
            //Action act = async () =>
            //{
			var q = new AttributeSetInstancesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            var req = new AttributeSetInstancesGetRequest();
            req.Query = q;
            var resp = _ramlClient.AttributeSetInstances.Get(req).GetAwaiter().GetResult();;
            states = resp.Content;
            //};
            //act();
            return states;
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }



    }


    public partial class AttributeSetInstanceApplicationServiceProxyFactory : IAttributeSetInstanceApplicationServiceFactory
    {

        private string _endpointUrl;

        public AttributeSetInstanceApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IAttributeSetInstanceApplicationService AttributeSetInstanceApplicationService
        {
            get
            {
                return new AttributeSetInstanceApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateAttributeSetInstance NewCreateAttributeSetInstance()
        {
            return new CreateAttributeSetInstanceDto();
        }

        public IMergePatchAttributeSetInstance NewMergePatchAttributeSetInstance()
        {
            return new MergePatchAttributeSetInstanceDto();
        }

        public IDeleteAttributeSetInstance NewDeleteAttributeSetInstance()
        {
            return new DeleteAttributeSetInstanceDto();
        }
    }


}
