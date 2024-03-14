using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14032024
{
    internal class Pedido
    {
        private List<Item> items { get; set; }
        private double valorTotal { get; set; }

        public Pedido()
        {
            items = new List<Item>();
        }

        public void adicionarItems(Item item)
        {
            if (items.Contains(item))
            {   
                foreach(Item i in items)
                {   
                    if(i.produto == item.produto)
                    {
                        i.quantidade += item.quantidade;
                    }          
                }
            }
            else
            {
                items.Add(item);
                valorTotal += item.valor;
            }           
        }      
        public void fazerPedido(Produto p, int quantidade, double desconto, double valor)
        {
            adicionarItems(new Item(p, quantidade, desconto, valor));
        }

        public void imprimirItems()
        {
            Console.WriteLine(valorTotal);
        }
    }
}
