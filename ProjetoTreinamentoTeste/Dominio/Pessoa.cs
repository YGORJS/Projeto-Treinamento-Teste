﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classe Mãe

namespace Dominio
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public Sexo Sexo { get; set; }
    }
}
