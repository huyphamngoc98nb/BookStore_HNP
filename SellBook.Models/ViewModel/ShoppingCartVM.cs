using SellBook.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellBook.Models.ViewModel
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart>? ListCart {  get; set; }

        public double OrderTotal;
    }
}
