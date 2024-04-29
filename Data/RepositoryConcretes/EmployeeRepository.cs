using Core.Abstracts;
using Core.Models;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcretes
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public List<Employee> GetAll()
        {
            string query = "SELECT * FROM Employees";
            DataTable dataTable = _appDbContext.Query(query);
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Employee employee = new Employee
                { 
                    Name = row["Name"].ToString(),
                    Surname = row["Surname"].ToString(),
                    Salary = double.Parse(row["Salary"].ToString())
                };
                employees.Add(employee);
            }

            return employees;
        }

        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }
    }
}
