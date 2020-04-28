using System;
using DependencyInjectionDAL.Interfaces;
using DependencyInjectionBuisness.Interfaces;


namespace DependencyInjectionBuisness.Buisness
{
    public class Employee
    {
        /*IDal MySQLserver;
        IBilling Billing;
        IEmail Email;
        IPrint Print;

        public Employee(IDal MySQLserver, IBilling Billing, IEmail Email, IPrint Print)
        {
            this.MySQLserver = MySQLserver;
            this.Billing = Billing;
            this.Email = Email;
            this.Print = Print;
        }*/

        IUnityLocator unityLocator;

        public Employee(IUnityLocator unityLocator)
        {
            this.unityLocator = unityLocator;
        }
        public void AddEmployee()
        {
            unityLocator.GetLocator<IDal>().RegisterEmployee();
            unityLocator.GetLocator<IBilling>().BillToEmployee();
            unityLocator.GetLocator<IEmail>().SendEmail();
            unityLocator.GetLocator<IPrint>().PrintStatus();

            Console.WriteLine("Successfull the emplyoee has been added");
        }
    }
}
