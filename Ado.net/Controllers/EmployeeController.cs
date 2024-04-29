using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net.Controllers
{
    public class EmployeeController
    {
        IEmployeeService _employeeService =new EmployeeService();
        public void Create()
        {
            Console.WriteLine("Name daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname daxil edin:");
            string surname= Console.ReadLine();
            string salaryStr = "";
            int salary;
            do
            {
                Console.WriteLine("Salary daxil edin:");
                salaryStr = Console.ReadLine();
            } while(int.TryParse(salaryStr, out salary));
            Employee employee = new Employee
            {
                Name = name,
                Surname = surname,
                Salary = salary
            };
            _employeeService.Create(employee);
        }
        public void Delete()
        {
            string idStr = "";
            int id;
            do
            {
                Console.WriteLine("Id daxil edin:");
                idStr = Console.ReadLine();
            } while (int.TryParse(idStr, out id));
            _employeeService.Delete(id);
        }
        public void Update()
        {
            string idStr = "";
            int id;
            do
            {
                Console.WriteLine("Id daxil edin:");
                idStr = Console.ReadLine();
            } while (int.TryParse(idStr, out id));
            Console.WriteLine("Name daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname daxil edin:");
            string surname = Console.ReadLine();
            string salaryStr = "";
            int salary;
            do
            {
                Console.WriteLine("Salary daxil edin:");
                salaryStr = Console.ReadLine();
            } while (int.TryParse(salaryStr, out salary));
            Employee employee = new Employee
            {
                Name = name,
                Surname = surname,
                Salary = salary
            };
            _employeeService.Update(employee, id);
        }
        public List<Employee> GetAll()
        {
            return _employeeService.GetAll();
        }
    }
}
