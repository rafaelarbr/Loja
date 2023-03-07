using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Dados
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tamanho { get; set; }
        public double Preco { get; set; }
    }
}
