using Ado.net.Controllers;
using Business.Services.Concretes;
using System.Data.SqlClient;

namespace Ado.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
          EmployeeController employeeController = new EmployeeController();
            employeeController.Create();
            employeeController.Update();
            employeeController.Delete();
            employeeController.GetAll();

        }
    }
}
