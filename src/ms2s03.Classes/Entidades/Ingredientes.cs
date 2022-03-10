using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Ingrediente
    {
        public Ingrediente(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

    }
}
