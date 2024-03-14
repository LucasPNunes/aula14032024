using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14032024
{
    internal class Produto
    {   
        public int id { get; set; }
        public double preco { get; private set; }
        public string nome { get; private set; }

        public Produto(double preco, string nome)
        {
            this.preco = preco;
            this.nome = nome;
        }
    }
}
