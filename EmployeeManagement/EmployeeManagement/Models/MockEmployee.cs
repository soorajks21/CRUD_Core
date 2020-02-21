using EmployeeManagement.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployee : IEmployeeInterface
    {
        List<Employee> employees;

        public MockEmployee()
        {
            employees = new List<Employee>
            {
                new Employee{Id = 101, Name ="Sooraj", Email = "Soorajks@live.in", Department = "CSE"  },
                new Employee{Id = 102, Name ="Sibi", Email = "Sibi@live.in", Department = "EEE"  },
                new Employee{Id = 103, Name ="Murali", Email = "Murali@live.in", Department = "MEC"  },
                new Employee{Id = 104, Name ="Maddy", Email = "Maddy@live.in", Department = "CE"  }
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }
    }
}
