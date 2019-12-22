using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;
using EstoqueEntityModel;

namespace Estoques
{
    // WCF service that implements the service contract 
    // This implementation performs minimal error checking and exception handling 
    [AspNetCompatibilityRequirements(
    RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EstoqueService : IEstoqueService, IEstoqueServiceV2
    {
        public bool AdicionarQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade)
        {
            try
            {
                using (EstoqueEntityModel.ProvedorEstoque database = new EstoqueEntityModel.ProvedorEstoque())
                {
                    Estoque matchingEstoque = database.Estoques.First(
                        e => String.Compare(e.NumeroProduto, NumeroProdutoEstoque) == 0);

                    matchingEstoque.EstoqueProduto += Quantidade;
                    database.Estoques.Add(matchingEstoque);
                    database.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public int ConsultarEstoque(string NumeroProdutoEstoque)
        {
            int quantidadeEstoque = 0;
            try
            {
                using (EstoqueEntityModel.ProvedorEstoque database = new EstoqueEntityModel.ProvedorEstoque())
                {
                    Estoque matchingEstoque = database.Estoques.First(
                        e => String.Compare(e.NumeroProduto, NumeroProdutoEstoque) == 0);

                    quantidadeEstoque = matchingEstoque.EstoqueProduto;
                }

            }
            catch
            {

            }

            return quantidadeEstoque;
        }

        public bool IncluirProdutoEstoque(EstoqueData Estoque)
        {
            try
            {
                using (EstoqueEntityModel.ProvedorEstoque database = new EstoqueEntityModel.ProvedorEstoque())
                {
                    Estoque estoqueDb = new Estoque()
                    {
                        NumeroProduto = Estoque.NumeroProduto,
                        NomeProduto = Estoque.NomeProduto,
                        DescricaoProduto = Estoque.DescricaoProduto,
                        EstoqueProduto = Estoque.EstoqueProduto
                    };

                    database.Estoques.Add(estoqueDb);
                    database.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        
        }

        public List<EstoqueData> ListarProdutosEstoque()
        {
            List<EstoqueData> produtosEstoqueList = new List<EstoqueData>();
            try
            {
                using (EstoqueEntityModel.ProvedorEstoque database = new EstoqueEntityModel.ProvedorEstoque())
                {
                    List<Estoque> estoques = (from estoque in database.Estoques
                                              select estoque).ToList();

                    foreach(Estoque estoque in estoques)
                    {
                        EstoqueData estoqueData = new EstoqueData()
                        {
                            NumeroProduto = estoque.NumeroProduto,
                            NomeProduto = estoque.NomeProduto,
                            DescricaoProduto = estoque.DescricaoProduto,
                            EstoqueProduto = estoque.EstoqueProduto
                        };
                        produtosEstoqueList.Add(estoqueData);
                    }
                }
            }
            catch
            {

            }
            return produtosEstoqueList;
        }

        public bool RemoverProdutoEstoque(string NumeroProdutoEstoque)
        {
            try
            {
                using (EstoqueEntityModel.ProvedorEstoque database = new EstoqueEntityModel.ProvedorEstoque())
                {
                    Estoque matchingEstoque = database.Estoques.First(
                        e => String.Compare(e.NumeroProduto, NumeroProdutoEstoque) == 0);
                    
                    database.Estoques.Remove(matchingEstoque);
                    database.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        
        }

        public bool RemoverQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade)
        {
            try
            {
                using (EstoqueEntityModel.ProvedorEstoque database = new EstoqueEntityModel.ProvedorEstoque())
                {
                    Estoque matchingEstoque = database.Estoques.First(
                        e => String.Compare(e.NumeroProduto, NumeroProdutoEstoque) == 0);

                    matchingEstoque.EstoqueProduto -= Quantidade;
                    database.Estoques.Add(matchingEstoque);
                    database.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public EstoqueData VerProdutoEstoque(string NumeroProdutoEstoque)
        {
            EstoqueData estoqueData = null;
            try
            {
                using (EstoqueEntityModel.ProvedorEstoque database = new EstoqueEntityModel.ProvedorEstoque())
                {
                    Estoque matchingEstoque = database.Estoques.First(
                        e => String.Compare(e.NumeroProduto, NumeroProdutoEstoque) == 0);
                    estoqueData = new EstoqueData()
                    {
                        NumeroProduto = matchingEstoque.NumeroProduto,
                        NomeProduto = matchingEstoque.NomeProduto,
                        DescricaoProduto = matchingEstoque.DescricaoProduto,
                        EstoqueProduto = matchingEstoque.EstoqueProduto
                    };
                }
            }
            catch
            {

            }
            return estoqueData;
        }
    }
}
