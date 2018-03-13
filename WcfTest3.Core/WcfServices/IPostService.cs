using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfTest3.Core;
using WcfTest3.Core.WcfContracts;

namespace WcfTest3.Core.WcfServices
{
    [ServiceContract]
    public interface IPostService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Posts?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PostContract Get(int Id);

        [OperationContract]
        [WebGet(UriTemplate = "/Posts/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PostContract> GetAll();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Posts/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PostContract Create(PostContract post);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/Posts/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PostContract Update(PostContract post);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/Posts?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void Delete(int Id);
    }
}
