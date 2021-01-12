using System.Collections.Generic;
using API.Interfaces;

namespace API.Entities
{
    public class Employee : IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }  
         public List<Order> OrderList { get; set; }
        public string MyProperty { get; set; }
        public string Position { get; set; }
        
    }
}