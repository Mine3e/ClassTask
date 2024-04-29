using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts
{
    public interface IEmployeeService
    {
        void Delete(int id);
        void Create(Employee employee);
        List<Employee> GetAll();
        void Update(Employee employee, int id);
    }
}
