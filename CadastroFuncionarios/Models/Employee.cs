﻿using System;
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
        public Department department { get; set; }
        
    }
}
