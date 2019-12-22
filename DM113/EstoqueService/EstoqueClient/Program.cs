using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EstoqueClient.EstoqueService;

namespace EstoqueClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            EstoqueServiceClient proxy = new EstoqueServiceClient("WS2007HttpBinding_IEstoqueService");
            
            Console.WriteLine("1) Verificar o estoque atual do Produto 1");

            int estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque do Produto 1: {0}", estoqueProduto1);

            Console.WriteLine("2) Adicionar 20 unidades para este produto");

            bool addEstoqueProduto1Sucesso = proxy.AdicionarQtdeProdutoEstoque("1000", 20);
            if (addEstoqueProduto1Sucesso)
            {
                Console.WriteLine("Adicionadas 20 unidades no produto 1 com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao adiconar estoque");
            }

            Console.WriteLine("3) Verificar o estoque do Produto 1 novamente");

            estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque Produto 1: {0}", estoqueProduto1);

            Console.WriteLine("4) Verificar o estoque do Produto 5");

            int estoqueProduto5 = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Estoque Produto 5: {0}", estoqueProduto5);

            Console.WriteLine("5) Remover 10 unidades para este produto");

            bool removeComSucesso = proxy.RemoverQtdeProdutoEstoque("5000", 10);
            if (removeComSucesso)
            {
                Console.WriteLine("Removido com sucesso 10 unidades do Produto 5");
            }
            else
            {
                Console.WriteLine("Erro ao remover estoque");
            }
            
            Console.WriteLine("6) Verificar o estoque do Produto 5 novamente");

            estoqueProduto5 = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Estoque Produto 5: {0}", estoqueProduto5);

            // Disconnect from the service
            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();

        }
    }
}
