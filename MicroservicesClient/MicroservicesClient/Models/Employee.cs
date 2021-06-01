using System;
namespace MicroservicesClient.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool Ispermanent { get; set; }
        public Employee()
        {
        }
    }
}
