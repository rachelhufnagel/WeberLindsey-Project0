using System;
using System.Collections.Generic;

namespace StoreDB.Models
{

    public class User
    {
        public int id { get; set; }
        public int locationId { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; } 
        public userType type { get; set; }
        public int orderId { get; set; }
        public List<Order> orders { get; set; }
        public int cartId { get; set; }
        public List<CartItem> cartItem { get; set; }

        public enum userType {
            Customer,
            Manager,
        }

    }
}