using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroFuncionarios.Models;

namespace CadastroFuncionarios.Data
{
    public class SeedingService
    {

        private CadastroFuncionariosContext _context;

        public SeedingService(CadastroFuncionariosContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Employee.Any())
            {
                return; // DB ja foi populado.
            }

            Department d1 = new Department(1,"Vendas");
            Department d2 = new Department(2,"Produção");
            Department d3 = new Department(3,"TI");

            Employee e1 = new Employee(1,"Marcio",2000.0,d3);
            Employee e2 = new Employee(2,"Maysa",2000.0,d1);
            Employee e3 = new Employee(3, "Flavio",3000.0,d2);

            _context.Department.AddRange(d1,d2,d3);
           _context.Employee.AddRange(e1,e2,e3);
            _context.SaveChanges();



        }
    }
}
