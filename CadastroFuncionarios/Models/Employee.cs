using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, double salary, Department department)
        {
            Id = id;
            this.name = name;
            this.salary = salary;
            Department = department;
        }
    }
}
