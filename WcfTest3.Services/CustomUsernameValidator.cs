using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Data;

namespace WcfTest3.Services
{
    public class CustomUsernameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new FaultException("Username or password cannot be empty.");
            }

            using (var context = new WcfTest3Entities())
            {
                using (var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(context)))
                {
                    var user = userManager.Find(userName, password);
                    if (user == null)
                    {
                        throw new FaultException("Username or password is wrong.");
                    }
                }

            }
        }
    }
}
