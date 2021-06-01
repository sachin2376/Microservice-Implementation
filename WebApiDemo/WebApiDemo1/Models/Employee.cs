using System;
namespace WebApiDemo1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsPermanent { get; set; }


        public Employee()
        {
        }
    }
}
