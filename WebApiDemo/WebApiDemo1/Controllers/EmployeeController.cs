using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo1.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        static List<Employee> employees = new List<Employee>
        {
            new Employee{Id = 101,Name="Justine",Salary=25000,IsPermanent=true},
            new Employee{Id = 102,Name="Ritika",Salary=5000,IsPermanent=false},
            new Employee{Id = 103,Name="Jasmine",Salary=51000,IsPermanent=true},
            new Employee{Id = 104,Name="Dhiraj",Salary=205000,IsPermanent=false}
        };
        // GET: api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            Employee employee = employees.Where(emp => emp.Id == id).FirstOrDefault();
            return employee;
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return "Addition Successful";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Employee employee)
        {
            Employee emp = employees.Where(emp => emp.Id == id).FirstOrDefault();
            if (emp == null)
                return ("Record doesn't exists!");
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.IsPermanent = employee.IsPermanent;
            return "Successfull !";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            Employee emp = employees.Where(emp => emp.Id == id).FirstOrDefault();
            employees.Remove(emp);
            return "Deleted !!!";
        }
    }
}
