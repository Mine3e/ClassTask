using Business.Services.Abstracts;
using Core.Models;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    
    public  class EmployeeService:IEmployeeService
    {
        AppDbContext dbContext;
        public EmployeeService()
        {
             this.dbContext = new AppDbContext();
        }

        public void Delete(int id)
        {
            string command=$"delete from Employees where id={id}";
            dbContext.NonQuery(command);
        }

        public void Create(Employee employee)
        {
            string createCommand = $"insert into Employees values( '{employee.Name}', '{employee.Surname}', {employee.Salary})";
            int result = dbContext.NonQuery(createCommand);
        }
        public void Update(Employee employee, int id)
        {
            string command=$"update Employees Set Name='{employee.Name}', Surname='{employee.Surname}', Salary={employee.Salary} where id={id}";
            dbContext.NonQuery(command);
        }
        public List<Employee> GetAll()
        {
            string query = "Select * from Employees";
            DataTable table=dbContext.Query(query);
            List<Employee> list = new List<Employee>();
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Employee()
                {
                    Id = int.Parse(item["Id"].ToString()),
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Salary = double.Parse(item["salary"].ToString()),

                });
            }
            return list;
        }
    }
}
