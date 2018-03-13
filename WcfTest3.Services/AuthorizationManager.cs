using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Data;

namespace WcfTest3.Services
{
    public class AuthorizationManager : ServiceAuthorizationManager
    {
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            using (var context = new WcfTest3Entities())
            {
                using (var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(context)))
                {
                    var identity = operationContext.ServiceSecurityContext.PrimaryIdentity;
                    var user = userManager.FindByName(identity.Name);
                    
                    if(user == null)
                    {
                        throw new FaultException("Username not known.");
                    }

                    var roles = userManager.GetRoles(user.Id).ToArray();

                    var principal = new GenericPrincipal(operationContext.ServiceSecurityContext.PrimaryIdentity, roles);
                    operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] = principal;

                    return true;
                }
            } 
        }
    }
}
