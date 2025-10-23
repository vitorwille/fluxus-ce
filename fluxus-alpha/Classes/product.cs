using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluxus_alpha.Classes
{
    public class Product
    {
        public int idProduto { get; set; }
        public string produto { get; set; }
        public string obsProduto { get; set; }
        public int qtdProduto { get; set; }
        public float valorProduto { get; set; }

        public float valorTotalProduto => qtdProduto * valorProduto;
    }
}
