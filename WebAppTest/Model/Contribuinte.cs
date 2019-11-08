﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTest.Model
{
    public class Contribuinte
    {
        public int ContribuinteId { get; set; }
        public string Nome { get; set; }
        public Double Salario { get; set; }
        public int Dependentes { get; set; }
        public Double? ValorIR { get; set; }
    }
}
