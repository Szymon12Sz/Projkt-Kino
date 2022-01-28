using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy_Kino.Data.Cart;

namespace Udemy_Kino.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
