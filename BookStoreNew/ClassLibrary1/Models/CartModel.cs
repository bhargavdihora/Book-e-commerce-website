using BookStoreNew.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreNew.Models.Models
{
    public class CartModel
    {
        public CartModel() { }

        public CartModel(Cart cart)
        {
            Id = cart.Id;
            UserId = cart.Userid;
            BookId = cart.Bookid;
            Quantity = cart.Quantity;   

        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}
