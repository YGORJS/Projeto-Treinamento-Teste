using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ator : Pessoa
    {
        public ICollection<Obra> Obras{ get; set; }
        public string Biografia { get; set; }
    }
}
