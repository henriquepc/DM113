using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Estoques
{
    [DataContract]
    public class EstoqueData
    {
        [DataMember]
        public string NumeroProduto;

        [DataMember]
        public string NomeProduto;

        [DataMember]
        public string DescricaoProduto;

        [DataMember]
        public int EstoqueProduto;        
    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IEstoqueService")]
    public interface IEstoqueService
    {
        [OperationContract]
        List<EstoqueData> ListarProdutosEstoque();

        [OperationContract]
        Boolean IncluirProdutoEstoque(EstoqueData Estoque);

        [OperationContract]
        Boolean RemoverProdutoEstoque(String NumeroProdutoEstoque);

        [OperationContract]
        int ConsultarEstoque(String NumeroProdutoEstoque);

        [OperationContract]
        Boolean AdicionarQtdeProdutoEstoque(String NumeroProdutoEstoque, int Quantidade);

        [OperationContract]
        Boolean RemoverQtdeProdutoEstoque(String NumeroProdutoEstoque, int Quantidade);

        [OperationContract]
        EstoqueData VerProdutoEstoque(String NumeroProdutoEstoque);
    }


    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IEstoqueServiceV2")]
    public interface IEstoqueServiceV2
    {
        [OperationContract]
        bool AdicionarQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade);

        [OperationContract]
        bool RemoverQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade);

        [OperationContract]
        int ConsultarEstoque(string NumeroProdutoEstoque);
    }

}
