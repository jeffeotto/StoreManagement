using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Order
    {
        [Key]
        public string ProductName { get; set; }
        public string State { get; set; }
        public Client Client { get; set; }
        public Employee Employee { get; set; }
        public DateTime DateAsigned { get; set; }
        public DateTime DateDelivered { get; set; }
    }
}