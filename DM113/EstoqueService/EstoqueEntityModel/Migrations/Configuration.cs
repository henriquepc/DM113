namespace EstoqueEntityModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EstoqueEntityModel.ProvedorEstoque>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EstoqueEntityModel.ProvedorEstoque context)
        {
            context.Estoques.AddOrUpdate(
               e => e.Id,
               new Estoque { NumeroProduto = "1000", NomeProduto = "Produto 1", DescricaoProduto = "Este é o produto 1", EstoqueProduto = 100 },
               new Estoque { NumeroProduto = "2000", NomeProduto = "Produto 2", DescricaoProduto = "Este é o produto 2", EstoqueProduto = 10 },
               new Estoque { NumeroProduto = "3000", NomeProduto = "Produto 3", DescricaoProduto = "Este é o produto 3", EstoqueProduto = 200 },
               new Estoque { NumeroProduto = "4000", NomeProduto = "Produto 4", DescricaoProduto = "Este é o produto 4", EstoqueProduto = 300 },
               new Estoque { NumeroProduto = "5000", NomeProduto = "Produto 5", DescricaoProduto = "Este é o produto 5", EstoqueProduto = 400 },
               new Estoque { NumeroProduto = "6000", NomeProduto = "Produto 6", DescricaoProduto = "Este é o produto 6", EstoqueProduto = 500 },
               new Estoque { NumeroProduto = "7000", NomeProduto = "Produto 7", DescricaoProduto = "Este é o produto 7", EstoqueProduto = 30 },
               new Estoque { NumeroProduto = "8000", NomeProduto = "Produto 8", DescricaoProduto = "Este é o produto 8", EstoqueProduto = 30 },
               new Estoque { NumeroProduto = "9000", NomeProduto = "Produto 9", DescricaoProduto = "Este é o produto 9", EstoqueProduto = 400 },
               new Estoque { NumeroProduto = "10000", NomeProduto = "Produto 10", DescricaoProduto = "Este é o produto 10", EstoqueProduto = 2 }
                );
        }
    }
}
