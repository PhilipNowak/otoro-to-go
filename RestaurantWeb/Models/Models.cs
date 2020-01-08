using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWeb.Models
{
    public class Models
    {
        public class User
        {
            public int UserId { get; set; }
        }

        public class MenuItem
        {
            public int MenuItemId { get; set; }

            public decimal Price { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string GroupName { get; set; }
            public bool IsInStock { get; set; }

        }

        public class MenuItemAvailabilty
        {
            public int MenuItemAvailabiltyId { get; set; }
            public int MenuItemId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public bool IsRecurring { get; set; }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public int UserId { get; set; }
            public OrderType OrderType { get; set; }
            //should be broken up
            public decimal Fee { get; set; }
            public DateTime OrderTime { get; set; }
            public bool OrderComplete { get; set; }
            public DateTime CompleteTime { get; set; }
            public bool HasPayed { get; set; }


            public User User { get; set; }
            public List<OrderItem> OrderItem { get; set; }
        }

        public class OrderItem
        {
            public int OrderId { get; set; }
            public int MenuItemId { get; set; }
            public int Quantity { get; set; }
            public decimal PricePerItem { get; set; }

            public Order TotalOrder { get; set; }
            public MenuItem MenuItem { get; set; }
        }

        public enum OrderType
        {
            Delivery,
            CarryOut
        }
    }
}
