﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstoqueClient.EstoqueService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstoqueData", Namespace="http://schemas.datacontract.org/2004/07/Estoques")]
    public partial class EstoqueData : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescricaoProdutoField;
        
        private int EstoqueProdutoField;
        
        private string NomeProdutoField;
        
        private string NumeroProdutoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoProduto
        {
            get
            {
                return this.DescricaoProdutoField;
            }
            set
            {
                this.DescricaoProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto
        {
            get
            {
                return this.EstoqueProdutoField;
            }
            set
            {
                this.EstoqueProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto
        {
            get
            {
                return this.NomeProdutoField;
            }
            set
            {
                this.NomeProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto
        {
            get
            {
                return this.NumeroProdutoField;
            }
            set
            {
                this.NumeroProdutoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstoqueClient.EstoqueService.IEstoqueService")]
    public interface IEstoqueService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ListarProdutosEstoque", ReplyAction="http://tempuri.org/IEstoqueService/ListarProdutosEstoqueResponse")]
        EstoqueClient.EstoqueService.EstoqueData[] ListarProdutosEstoque();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ListarProdutosEstoque", ReplyAction="http://tempuri.org/IEstoqueService/ListarProdutosEstoqueResponse")]
        System.Threading.Tasks.Task<EstoqueClient.EstoqueService.EstoqueData[]> ListarProdutosEstoqueAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/IncluirProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/IncluirProdutoEstoqueResponse")]
        bool IncluirProdutoEstoque(EstoqueClient.EstoqueService.EstoqueData Estoque);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/IncluirProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/IncluirProdutoEstoqueResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoEstoqueAsync(EstoqueClient.EstoqueService.EstoqueData Estoque);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/RemoverProdutoEstoqueResponse")]
        bool RemoverProdutoEstoque(string NumeroProdutoEstoque);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/RemoverProdutoEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoEstoqueAsync(string NumeroProdutoEstoque);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ConsultarEstoque", ReplyAction="http://tempuri.org/IEstoqueService/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProdutoEstoque);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/ConsultarEstoque", ReplyAction="http://tempuri.org/IEstoqueService/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProdutoEstoque);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/AdicionarQtdeProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/AdicionarQtdeProdutoEstoqueResponse")]
        bool AdicionarQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/AdicionarQtdeProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/AdicionarQtdeProdutoEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarQtdeProdutoEstoqueAsync(string NumeroProdutoEstoque, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverQtdeProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/RemoverQtdeProdutoEstoqueResponse")]
        bool RemoverQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/RemoverQtdeProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/RemoverQtdeProdutoEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverQtdeProdutoEstoqueAsync(string NumeroProdutoEstoque, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/VerProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/VerProdutoEstoqueResponse")]
        EstoqueClient.EstoqueService.EstoqueData VerProdutoEstoque(string NumeroProdutoEstoque);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstoqueService/VerProdutoEstoque", ReplyAction="http://tempuri.org/IEstoqueService/VerProdutoEstoqueResponse")]
        System.Threading.Tasks.Task<EstoqueClient.EstoqueService.EstoqueData> VerProdutoEstoqueAsync(string NumeroProdutoEstoque);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstoqueServiceChannel : EstoqueClient.EstoqueService.IEstoqueService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstoqueServiceClient : System.ServiceModel.ClientBase<EstoqueClient.EstoqueService.IEstoqueService>, EstoqueClient.EstoqueService.IEstoqueService
    {
        
        public EstoqueServiceClient()
        {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public EstoqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public EstoqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public EstoqueClient.EstoqueService.EstoqueData[] ListarProdutosEstoque()
        {
            return base.Channel.ListarProdutosEstoque();
        }
        
        public System.Threading.Tasks.Task<EstoqueClient.EstoqueService.EstoqueData[]> ListarProdutosEstoqueAsync()
        {
            return base.Channel.ListarProdutosEstoqueAsync();
        }
        
        public bool IncluirProdutoEstoque(EstoqueClient.EstoqueService.EstoqueData Estoque)
        {
            return base.Channel.IncluirProdutoEstoque(Estoque);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoEstoqueAsync(EstoqueClient.EstoqueService.EstoqueData Estoque)
        {
            return base.Channel.IncluirProdutoEstoqueAsync(Estoque);
        }
        
        public bool RemoverProdutoEstoque(string NumeroProdutoEstoque)
        {
            return base.Channel.RemoverProdutoEstoque(NumeroProdutoEstoque);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoEstoqueAsync(string NumeroProdutoEstoque)
        {
            return base.Channel.RemoverProdutoEstoqueAsync(NumeroProdutoEstoque);
        }
        
        public int ConsultarEstoque(string NumeroProdutoEstoque)
        {
            return base.Channel.ConsultarEstoque(NumeroProdutoEstoque);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProdutoEstoque)
        {
            return base.Channel.ConsultarEstoqueAsync(NumeroProdutoEstoque);
        }
        
        public bool AdicionarQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade)
        {
            return base.Channel.AdicionarQtdeProdutoEstoque(NumeroProdutoEstoque, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarQtdeProdutoEstoqueAsync(string NumeroProdutoEstoque, int Quantidade)
        {
            return base.Channel.AdicionarQtdeProdutoEstoqueAsync(NumeroProdutoEstoque, Quantidade);
        }
        
        public bool RemoverQtdeProdutoEstoque(string NumeroProdutoEstoque, int Quantidade)
        {
            return base.Channel.RemoverQtdeProdutoEstoque(NumeroProdutoEstoque, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverQtdeProdutoEstoqueAsync(string NumeroProdutoEstoque, int Quantidade)
        {
            return base.Channel.RemoverQtdeProdutoEstoqueAsync(NumeroProdutoEstoque, Quantidade);
        }
        
        public EstoqueClient.EstoqueService.EstoqueData VerProdutoEstoque(string NumeroProdutoEstoque)
        {
            return base.Channel.VerProdutoEstoque(NumeroProdutoEstoque);
        }
        
        public System.Threading.Tasks.Task<EstoqueClient.EstoqueService.EstoqueData> VerProdutoEstoqueAsync(string NumeroProdutoEstoque)
        {
            return base.Channel.VerProdutoEstoqueAsync(NumeroProdutoEstoque);
        }
    }
}
