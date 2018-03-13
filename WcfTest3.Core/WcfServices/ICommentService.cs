using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Core.WcfContracts;

namespace WcfTest3.Core.WcfServices
{
    [ServiceContract]
    public interface ICommentService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Comments?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        CommentContract Get(int Id);

        [OperationContract]
        [WebGet(UriTemplate = "/Comments/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<CommentContract> GetAll();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Comments/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        CommentContract Create(CommentContract comment, int postId);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/Comments/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        CommentContract Update(CommentContract comment);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/Comments?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void Delete(int Id);
    }
}
