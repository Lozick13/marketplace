using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketplace
{
    public class MarketplaceModels
    {
        public class User
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
        public class Seller
        {
            public int SellerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Webpage { get; set; }
        }
        public class Product
        {
            public int ProductId { get; set; }
            public int SellerId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int PointId { get; set; }
            public int ProductCount { get; set; }
        }
        public class PickupPoint
        {
            public int PointId { get; set; }
            public string Location { get; set; }
            public string ManagerName { get; set; }
            public double Rating { get; set; }
            public int OrderCount { get; set; }
            public int EmployeeCount { get; set; }
        }
        public class Employee
        {
            public int EmployeeId { get; set; }
            public int PointId { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public decimal Salary { get; set; }
            public int OrderCount { get; set; }
        }
        public class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }
        public class Order
        {
            public int OrderId { get; set; }
            public int CustomerId { get; set; }
            public int EmployeeId { get; set; }
            public DateTime OrderDate { get; set; }
            public string Status { get; set; }
        }
        public class OrderedProduct
        {
            public int RecordId { get; set; }
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }
}
