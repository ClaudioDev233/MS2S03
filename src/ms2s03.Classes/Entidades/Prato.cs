using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Prato
    {
        public Prato(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            Ingrediente = new List<Ingrediente>();
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public List<Ingrediente> Ingrediente{ get; private set; }

        public void AdicionaIngrediente(List<Ingrediente> ingrediente)
        {
            Ingrediente.AddRange(ingrediente);
        }

        public void MostrarIngredientes()
        {
            Console.WriteLine($"A lista de ingredientes de {Nome} é:");

            foreach(var ingrediente in Ingrediente)
            {
                Console.WriteLine(ingrediente.Nome);
            }
        }
    }
}
