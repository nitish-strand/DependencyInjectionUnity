using System;
using DependencyInjectionBuisness.Buisness;
using DependencyInjectionBuisness.Interfaces;
using DependencyInjectionDAL.Interfaces;
//using DependencyInjectionDAL.MySQLserver;
using DependencyInjectionDAL.MangoDBserver;
using Unity;

namespace DependencyInjectionUnityTest
{
    // UI Layer
    public class Program
    {
        public static IUnityContainer container;
        public static void Main(string[] args)
        {

            /*//Partial Coupling
            IDal server = new MySQLserver();
            //IDal server = new MangoDBserver();

            IBilling bill = new Billing();
            IEmail email = new Email();
            IPrint print = new Print();

            Employee emp = new Employee(server, bill, email, print);
            emp.AddEmployee();
            */

            //full coupling
            container = new UnityContainer();
            container.RegisterType<Employee>();
            container.RegisterType<IDal, MangoDBserver>();
            //container.RegisterType<IDal, MySQLserver>();
            container.RegisterType<IBilling, Billing>();
            container.RegisterType<IEmail, Email>();
            container.RegisterType<IPrint, Print>();

            container.RegisterType<IUnityLocator, UnityLocator>();

            Employee emp = container.Resolve<Employee>();
            emp.AddEmployee();

            Console.Read();
            
        }
    }
}
