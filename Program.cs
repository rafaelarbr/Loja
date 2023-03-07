using Loja.Dados;

namespace Loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opcao vendedorOuCliente;
            List<Produto> produtos = new List<Produto>();
            Cliente cliente = new Cliente();
            Vendedor vendedor = new Vendedor();

            do
            {
                do
                {
                    Console.WriteLine("Você é vendedor ou cliente?");
                    Console.WriteLine("1. Vendedor, 2. Cliente");
                    vendedorOuCliente = (Opcao)Convert.ToInt32(Console.ReadLine());

                    if (vendedorOuCliente != Opcao.Vendedor && vendedorOuCliente != Opcao.Cliente)
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                } while (vendedorOuCliente != Opcao.Vendedor && vendedorOuCliente != Opcao.Cliente);

                if (vendedorOuCliente == Opcao.Vendedor)
                {
                    OpcaoVendedor opcaoVendedor;
                    
                    do
                    {
                        Console.WriteLine("O que você gostaria de fazer?");
                        Console.WriteLine("1. Cadastrar produto, 2. Exibir produtos, 3. Editar produtos, 4. Excluir produtos");
                        opcaoVendedor = (OpcaoVendedor)Convert.ToInt32(Console.ReadLine());

                        if (opcaoVendedor != OpcaoVendedor.CadastrarProduto && opcaoVendedor != OpcaoVendedor.ExibirProdutos && opcaoVendedor != OpcaoVendedor.EditarProdutos && opcaoVendedor != OpcaoVendedor.ExcluirProdutos)
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                    } while (opcaoVendedor != OpcaoVendedor.CadastrarProduto && opcaoVendedor != OpcaoVendedor.ExibirProdutos && opcaoVendedor != OpcaoVendedor.EditarProdutos && opcaoVendedor != OpcaoVendedor.ExcluirProdutos);

                    switch (opcaoVendedor)
                    {
                        case OpcaoVendedor.CadastrarProduto:
                            produtos = vendedor.Cadastrar(produtos);
                            break;
                        case OpcaoVendedor.ExibirProdutos:
                            vendedor.Exibir(produtos);
                            break;
                        case OpcaoVendedor.EditarProdutos:
                            produtos = vendedor.Editar(produtos);
                            break;
                        case OpcaoVendedor.ExcluirProdutos:
                            produtos = vendedor.Excluir(produtos);
                            break;
                        default:
                            break;
                    }
                }
                else if (vendedorOuCliente == Opcao.Cliente)
                {
                    OpcaoCliente opcaoCliente;
                    
                    do
                    {
                        Console.WriteLine("O que você gostaria de fazer?");
                        Console.WriteLine("1. Exibir todos produtos, 2. Adcionar ao carrinho, 3. Excluir produtos do carrinho, 4. Exibir produtos do carrinho");
                        opcaoCliente = (OpcaoCliente)Convert.ToInt32(Console.ReadLine());

                        if (opcaoCliente != OpcaoCliente.ExibirTodosProdutos && opcaoCliente != OpcaoCliente.AdicionarNoCarrinho && opcaoCliente != OpcaoCliente.ExcluirProdutosDoCarrinho && opcaoCliente != OpcaoCliente.ExibirProdutosDoCarrinho)
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                    } while (opcaoCliente != OpcaoCliente.ExibirTodosProdutos && opcaoCliente != OpcaoCliente.AdicionarNoCarrinho && opcaoCliente != OpcaoCliente.ExcluirProdutosDoCarrinho && opcaoCliente != OpcaoCliente.ExibirProdutosDoCarrinho);
                    switch (opcaoCliente)
                    {
                        case OpcaoCliente.ExibirTodosProdutos:
                            cliente.Exibir(produtos);
                            break;
                        case OpcaoCliente.AdicionarNoCarrinho:
                            cliente.Adicionar(produtos);
                            break;
                        case OpcaoCliente.ExcluirProdutosDoCarrinho:
                            cliente.Excluir();
                            break;
                        case OpcaoCliente.ExibirProdutosDoCarrinho:
                            cliente.ExibirCarrinho();
                            break;
                        default:
                            break;
                    }
                }
            } while (true);
        }

    }
}