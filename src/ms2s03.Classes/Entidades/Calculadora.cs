using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Calculadora
    {
        private int _valor1;
        private int _valor2;

        private string _operacao;

        public int Valor1 { get => _valor1; set => _valor1 = value; }
        public int Valor2 { get => _valor2; set => _valor2 = value; }
        public string Operacao { get => _operacao; set => _operacao = value; }


        public int Soma => _valor1 + _valor2;

        public string Calcular()
        {
            if (Operacao == "+" || Operacao == "-" || Operacao == "*" || Operacao == "/")
           
            if (Operacao == "+")
            {
                return $"O resultado da soma entre {_valor1} e {_valor2} é : { _valor1 + _valor2} ";

;           };

            if (Operacao == "-")
            {
                return $"O resultado da subtração entre {_valor1} e {_valor2} é : { _valor1 - _valor2} ";

                ;
            };

            if (Operacao == "+")
            {
                return $"O resultado da multiplicação entre {_valor1} e {_valor2} é : { _valor1 * _valor2} ";

                ;
            };

            if (Operacao == "/")
            {
                if(_valor2 <= 0)
                {
                    return "Não é possivel dividir por 0";
                }
                return $"O resultado da divisão entre {_valor1} e {_valor2} é : { _valor1 / _valor2} ";

            };

            return "Operação Inválida";

        }

       
    }
}
