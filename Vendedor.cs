using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Dados

{
    public class Vendedor: Pessoa
    {
        private int idAtual = 1;

        public List<Produto> Cadastrar(List<Produto> produtos)
        {
            var produto = new Produto();

            produto.Id= idAtual;
            Console.WriteLine("Qual a descrição do produto");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("Qual o tamanho do produto?");
            produto.Tamanho = Console.ReadLine();

            bool caiuNaException;
            
            do
            {
                try
                {
                    caiuNaException = false;

                    Console.WriteLine("Qual o preço do produto?");
                    produto.Preco = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    caiuNaException = true;
                    
                    Console.WriteLine("Você digitou um formato inválido. Erro: " + ex.Message);
                }
            } while (caiuNaException); 
            
            produtos.Add(produto);

            idAtual++;

            return produtos;
        }

        public List<Produto> Editar(List<Produto> produtos)
        {
            if (!produtos.Any())
            {
                Console.WriteLine("Não há nenhum produto a ser editado." + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Qual produto você gostaria de editar?");
                var idEdicao = Convert.ToInt32(Console.ReadLine());

                if (!produtos.Any(produto => produto.Id == idEdicao))
                {
                    Console.WriteLine("O produto selecionado não está cadastrado." + Environment.NewLine);
                }
                else
                {
                    foreach (var produto in produtos)
                    {
                        if (idEdicao == produto.Id)
                        {
                            OpcaoEdicao opcaoEdicao;
                            do
                            {
                                Console.WriteLine("O que você quer editar?");
                                Console.WriteLine("1. Descrição, 2. Tamanho, 3. Preço");
                                opcaoEdicao = (OpcaoEdicao)Convert.ToInt32(Console.ReadLine());

                            } while (opcaoEdicao != OpcaoEdicao.EdicaoDescricao && opcaoEdicao != OpcaoEdicao.EdicaoTamanho && opcaoEdicao != OpcaoEdicao.EdicaoPreco);
                            
                            if (opcaoEdicao == OpcaoEdicao.EdicaoDescricao)
                            {
                                Console.WriteLine("Qual a nova descrição?");
                                produto.Descricao = Console.ReadLine();
                            }
                            else if (opcaoEdicao == OpcaoEdicao.EdicaoTamanho)
                            {
                                Console.WriteLine("Qual o novo tamanho?");
                                produto.Tamanho = Console.ReadLine();      
                            }
                            else
                            {
                                bool caiuNaException;

                                do
                                {
                                    try
                                    {
                                        caiuNaException = false;

                                        Console.WriteLine("Qual o preço do produto?");
                                        produto.Preco = Convert.ToDouble(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        caiuNaException = true;

                                        Console.WriteLine("Você digitou um formato inválido. Erro: " + ex.Message);
                                    }
                                } while (caiuNaException);
                            }
                        }
                    }
                }
            }
            return produtos;
        }

        public List<Produto> Excluir(List<Produto> produtos)
        {
            if (!produtos.Any())
            {
                Console.WriteLine("Não há nenhum produto a ser excluido." + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Qual produto você gostaria de excluir?");
                var idExclusao = Convert.ToInt32(Console.ReadLine());

                if (!produtos.Any(produto => produto.Id == idExclusao))
                {
                    Console.WriteLine("O produto selecionado não está cadastrado." + Environment.NewLine);
                }
                else
                {
                    foreach (var produto in produtos.ToList())
                    {
                        if (idExclusao == produto.Id)
                        {
                            produtos.Remove(produto);
                        }
                    }
                }
            }
            return produtos;
        }

    }
}
