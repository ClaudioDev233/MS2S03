using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Pedido
    {
        
        public Pedido(DateOnly dataPedido)
        {
            DataPedido = dataPedido;

            ListaPratos = new List<Prato>();
        }

        public string QuantidadeDeItens()
        {
            return $"A quantidade de itens do pedido é { ListaPratos.Count()}";
        }

        public void AdicionaPrato(Prato prato)
        {
            ListaPratos.Add(prato);
        }

        public string ValorDoPedido()
        {
           var preco = ListaPratos.Sum(pedido => pedido.Preco);
            return $"O valor do pedido é{preco}";
        }

        public DateOnly DataPedido { get; set; }
        
        public List<Prato> ListaPratos { get; set; }
    }
}
