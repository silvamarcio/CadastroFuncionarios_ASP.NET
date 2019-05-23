using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroFuncionarios.Models;

namespace CadastroFuncionarios.Models
{
    public class CadastroFuncionariosContext : DbContext
    {
        public CadastroFuncionariosContext (DbContextOptions<CadastroFuncionariosContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroFuncionarios.Models.Department> Department { get; set; }

        public DbSet<CadastroFuncionarios.Models.Employee> Employee { get; set; }

        
    }
}
