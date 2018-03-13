using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Core.WcfContracts;

namespace WcfTest3.Core.WcfServices
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Categories?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        CategoryContract Get(int Id);

        [OperationContract]
        [WebGet(UriTemplate = "/Categories/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<CategoryContract> GetAll();

        [OperationContract]
        [WebGet(UriTemplate = "/Categories/{id}/posts", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PostContract> GetCategoryPosts(string Id);

        [PrincipalPermission(SecurityAction.Demand, Role = "Mod")]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Categories/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        CategoryContract Create(CategoryContract category);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/Categories/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        CategoryContract Update(CategoryContract category);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/Categories?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void Delete(int Id);
    }
}
