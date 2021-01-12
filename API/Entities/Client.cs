using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using API.Interfaces;

namespace API.Entities
{
    public class Client: IUser
    {
      [Key]
      public string UserName { get; set; }  
      public List<Order> OrderList { get; set; }
      public string Address { get; set; }
    }
}