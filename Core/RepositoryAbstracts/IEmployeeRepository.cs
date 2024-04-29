using Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts
{
    public  interface IEmployeeRepository
    {
        void Create(string command);
        void Delete(string command);
        void Update(string command);
        List<Employee> GetAll();
    }
}
