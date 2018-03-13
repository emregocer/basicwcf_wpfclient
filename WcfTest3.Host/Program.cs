using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Core.WcfServices;
using WcfTest3.Data;
using WcfTest3.Services;

namespace WcfTest3.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ServiceHost> hosts = new List<ServiceHost>();

            //Initialize Db. Requires ef packages for this project.
            try
            {
                Database.SetInitializer(new DatabaseInitializer<WcfTest3Entities>());
                using (var context = new WcfTest3Entities())
                {
                    context.Database.Initialize(force: true);
                    var x = context.Posts.Count();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception while initializing db: " + ex);
            }

            try
            {
                var section = ConfigurationManager.GetSection("system.serviceModel/services") as ServicesSection;
                if (section != null)
                {
                    Assembly implementationAssembly = Assembly.GetAssembly(typeof(CategoryService));

                    foreach (ServiceElement element in section.Services)
                    {
                        var serviceType = implementationAssembly.GetType(element.Name);
                        var host = new ServiceHost(serviceType);
                        host.Open();

                        Console.WriteLine(host.Description.Name + " opened.");
                        Console.WriteLine("Endpoints");
                        Console.WriteLine("=====================================");

                        foreach (var endpointAddr in host.Description.Endpoints)
                        {
                            Console.WriteLine(endpointAddr.Address);
                        }

                        Console.WriteLine(" ");
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }   
        }
    }
}
