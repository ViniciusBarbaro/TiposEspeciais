using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEspeciais.Boxes
{
    public class Sales
    {
        public Sales(int Id_,string Product_, decimal Price_ , DateTime DataVenda_)
        {
            Id = Id_;
            Product = Product_;
            Price = Price_;
            DataVenda = DataVenda_;
        }
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
