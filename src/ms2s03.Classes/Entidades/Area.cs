using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Area
    {
        private int _altura;
        private int _largura;

        public int Altura { get => _altura; set => _altura = value; }
        public int Largura { get => _largura; set => _largura = value; }
      
        public string CalculaArea()
        {
            if(Altura == Largura)
            {
            return $"A area do quadrado é {_altura * _largura}";
            }
            return $"A area do retagulo é {_altura * _largura}";
        }

        public string MostraDados()
        {

            return $"A altura é {_altura} e a largura é {_altura}";
        }
    }

}
