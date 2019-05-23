using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string  name { get; set; }


        public Department(int id, string name)
        {
            Id = id;
            this.name = name;
        }


    }
}
