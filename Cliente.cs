using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Dados
{
    public class Cliente: Pessoa
    {
        public List<Produto> carrinho = new List<Produto>();
       
        public void Adicionar(List<Produto> produtos)
        {
            if (!produtos.Any())
            {
                Console.WriteLine("Este produto não existe." + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Qual produto você gostaria de comprar?");
                var idProduto = Convert.ToInt32(Console.ReadLine());

                if (!produtos.Any(produto => produto.Id == idProduto))
                {
                    Console.WriteLine("O produto selecionado não existe." + Environment.NewLine);
                }
                else
                {
                    foreach (var produto in produtos)
                    {
                        if (idProduto == produto.Id)
                        {
                            carrinho.Add(produto);
                        }
                    }
                }
            }
        }

        public void Excluir()
        {
            if (!carrinho.Any())
            {
                Console.WriteLine("Não há nenhum produto a ser excluido do carrinho." + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Qual produto você deseja remover do seu carrinho?");
                var idExclusao = Convert.ToInt32(Console.ReadLine());

                if (!carrinho.Any(produto => produto.Id == idExclusao))
                {
                    Console.WriteLine("O produto selecionado não foi inserido no seu carrinho." + Environment.NewLine);
                }
                else
                {
                    foreach (var produto in carrinho.ToList())
                    {
                        if (idExclusao == produto.Id)
                        {
                            carrinho.Remove(produto);
                        }
                    }
                }
            }
        }

        public void ExibirCarrinho()
        {
            if (!carrinho.Any())
            {
                Console.WriteLine("Não existe nenhum produto no carrinho." + Environment.NewLine);
            }
            else
            {
                foreach (var produto in carrinho)
                {
                    Console.WriteLine(produto.Id + ". " + produto.Descricao + ", " + produto.Tamanho + ", " + produto.Preco + ".");
                }
            }
        }
    }
}
