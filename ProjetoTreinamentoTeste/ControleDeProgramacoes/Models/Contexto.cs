using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControleDeProgramacoes.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Obra> Obra;
        public DbSet<Ator> Ator;

        public Contexto () : base( "AcervoGlobo"){}

    }
}