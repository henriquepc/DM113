using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstoqueCliente1.ServiceReference1;

namespace EstoqueCliente1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press ENTER when the Client 1 has started");
            Console.ReadLine();

            EstoqueServiceClient proxy = new EstoqueServiceClient("BasicHttpBinding_IServicoEstoque");

            Console.WriteLine("Testes Cliente 1");
            
            Console.WriteLine("1) Adicionar um produto");

            EstoqueData produto = new EstoqueData
            {
                NumeroProduto = "11",
                NomeProduto = "Produto 11",
                DescricaoProduto = "Produto 11",
                EstoqueProduto = 11
            };

            bool produtoIncluidoSucesso = proxy.IncluirProdutoEstoque(produto);

            if (produtoIncluidoSucesso)
            {
                Console.WriteLine("Produto 11 incluído com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao incluir o Produto 11");
            }
            
            Console.WriteLine("2) Remover o produto 10");

            bool produtoRemovidoSucesso = proxy.RemoverProdutoEstoque("10");
            if (produtoRemovidoSucesso)
            {
                Console.WriteLine("Produto 10 removido com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao remover o Produto 10");
            }
            
            Console.WriteLine("3) Listar todos os produtos");

            List<EstoqueData> produtos = proxy.ListarProdutosEstoque().ToList();
            foreach (EstoqueData produtoEstoque in produtos)
            {
                Console.WriteLine();
                Console.WriteLine("Nome: ", produtoEstoque.NomeProduto);
                Console.WriteLine("Descrição Produto: ", produtoEstoque.DescricaoProduto);
                Console.WriteLine("Numero: ", produtoEstoque.NumeroProduto);
                Console.WriteLine("Estoque Produto: ", produtoEstoque.EstoqueProduto);
            }

            Console.WriteLine("4) Verificar todas as informações do Produto 2");

            produto = proxy.VerProdutoEstoque("2000");
            Console.WriteLine("Numero do Produto: {0}", produto.NumeroProduto);
            Console.WriteLine("Nome do Produto: {0}", produto.NomeProduto);
            Console.WriteLine("Descricao do Produto: {0}", produto.DescricaoProduto);
            Console.WriteLine("Estoque do Produto: {0}", produto.EstoqueProduto);
            
            Console.WriteLine("5) Adicionar 10 unidades para este produto");

            bool addEstoqueProduto2 = proxy.AdicionarQtdeProdutoEstoque("2000", 10);
            if (addEstoqueProduto2)
            {
                Console.WriteLine("10 unidades adiconadas ao estoque do Produto 2");
            }
            else
            {
                Console.WriteLine("Erro ao adiconar estoque!");
            }
            
            Console.WriteLine("6) Verificar o estoque do Produto 2");

            int estoqueProduto2 = proxy.ConsultarEstoque("2000");
            Console.WriteLine("Estoque do Produto 2: {0}", estoqueProduto2);
            
            Console.WriteLine("7) Verificar o estoque atual do Produto 1");

            int estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque atual do Produto 1: {0}", estoqueProduto1);
            
            Console.WriteLine("8) Remover 20 unidades para este produto");

            bool removeSucesso = proxy.RemoverQtdeProdutoEstoque("1000", 20);
            if (removeSucesso)
            {
                Console.WriteLine("20 unidades removidas do Produto 1");
            }
            else
            {
                Console.WriteLine("Erro ao remover estoque");
            }
            
            Console.WriteLine("9) Verificar o estoque do Produto 1 novamente");

            estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque atual do Produto 1: {0}", estoqueProduto1);
            
            Console.WriteLine("10) Verificar todas as informações do Produto 1");

            produto = proxy.VerProdutoEstoque("1000");
            Console.WriteLine("Numero do Produto: {0}", produto.NumeroProduto);
            Console.WriteLine("Nome do Produto: {0}", produto.NomeProduto);
            Console.WriteLine("Descricao do Produto: {0}", produto.DescricaoProduto);
            Console.WriteLine("Estoque do Produto: {0}", produto.EstoqueProduto);
            
            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();

        }
    }
}
