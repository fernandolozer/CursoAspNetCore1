using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_EF7.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int Qtde { get; set; }

    }
}
