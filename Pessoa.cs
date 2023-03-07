using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Dados
{
    public class Pessoa
    {
        public void Exibir(List<Produto> produtos)
        {
            if (!produtos.Any())
            {
                Console.WriteLine("Não há nenhum produto a ser exibido." + Environment.NewLine);
            }
            else
            {
                foreach (var produto in produtos)
                {
                    Console.WriteLine(produto.Id + ". " + produto.Descricao + ", " + produto.Tamanho + ", " + produto.Preco + ".");
                }
            }
        }
    }
}
