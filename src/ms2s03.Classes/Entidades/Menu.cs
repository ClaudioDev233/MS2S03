

namespace ms2s03.Classes.Entidades
{
    public class Menu
    {
        public Menu(string nomeRestaurante)
        {
            NomeRestaurante = nomeRestaurante;
            Pratos = new List<Prato>();
        }

        public string NomeRestaurante { get; private set; }
        
        public List<Prato> Pratos { get; private set;}

        public void AdicionaPratoAoMenu(Prato prato)
        {
            Pratos.Add(prato);
        }

        public void RetornaMenu()
        {
            Console.WriteLine($"Bem vindo ao {NomeRestaurante}, nosso Menu é composto por:");

            foreach( var prato in Pratos)
            {
                Console.WriteLine( $"{prato.Nome} Preço: {prato.Preco}");
                
            }
        }
    }
}
