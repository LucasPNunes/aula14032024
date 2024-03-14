using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14032024
{
    internal class Item
    {
        public Produto produto { get; private set; }
        public int quantidade { get; set; }
        public double desconto { get; private set; }
        public double valor { get; private set; }

        public Item(Produto produto, int quantidade, double desconto, double valor)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.desconto = desconto;
            this.valor = produto.preco/((desconto + 100)/100);
        }

    }
}
