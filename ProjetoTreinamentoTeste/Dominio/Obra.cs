using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Obra
    {
        public long Id { get; set; }
        public DateTime AnoLancamento { get; set; }
        public string Descricao { get; set; }
        public Diretor Diretor { get; set; }
        public string Classificacao { get; set; }
        public Genero Genero { get; set; }
    }
}