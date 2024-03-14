using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14032024
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Dictionary<Produto, int> map = new Dictionary<Produto, int>();

            Produto p1 = new Produto(10, "Faca");
            Produto p2 = new Produto(50, "Granada");
            Produto p3 = new Produto(80, "Urso");
            Produto p4 = new Produto(100, "Arma");
            Produto p5 = new Produto(1000, "Civic");

            Pedido pedido = new Pedido();
            pedido.fazerPedido(p1, 2, 0, p1.preco);
            pedido.fazerPedido(p2, 4, 0, p2.preco);
            pedido.fazerPedido(p3, 2, 0, p3.preco);
            pedido.fazerPedido(p4, 1, 0, p4.preco);
            pedido.fazerPedido(p5, 1, 0, p5.preco);

            pedido.imprimirItems();

            /*bool rodando = true;
            string opcao;
            while(rodando == true)
            {
                Console.WriteLine("0 - Fazer pedido");
                Console.WriteLine("1 - Sair.");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0":
                        
                        break;
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                }
            }*/
        }
    }
}
