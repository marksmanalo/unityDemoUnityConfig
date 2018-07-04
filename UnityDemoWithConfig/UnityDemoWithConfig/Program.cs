using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UnityDemoWithConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();

            IEmployee employee = container.Resolve<IEmployee>();

            Console.WriteLine(employee.ShowDatabaseConnection());

            Console.ReadLine();
        }
    }
}
