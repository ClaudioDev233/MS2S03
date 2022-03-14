using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Pessoas
    {
        public object Pessoa { get; set; }
        public List<Pessoa> ListaPessoa { get; set; }
       

        private string ExibeMaiorIdade()
        {

            ListaPessoa.Sort((idade1, idade2) => idade2.Idade.CompareTo(idade1.Idade));
            return $"A pessoa mais velha é {ListaPessoa[0].Nome}, com {ListaPessoa[0].Idade}";
                

        }
        public void AdicionarPessoas()
        {
             
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um nome");
                string nomePessoa = Console.ReadLine();
                Console.WriteLine("Digite a idade da pessoa");
                var idadePessoa = int.Parse(Console.ReadLine());
                var pessoa = new Pessoa(nomePessoa, idadePessoa);
                Console.WriteLine($"{pessoa.Nome} foi adicionado");
                if (ListaPessoa == null)
                    ListaPessoa = new List<Pessoa>();
                ListaPessoa.Add(pessoa);

            }

            foreach (var pessoa in ListaPessoa)
            {
                Console.WriteLine(pessoa.Nome);
            };

            var coiso = ExibeMaiorIdade();

            Console.WriteLine(coiso);

        }
    }
}
