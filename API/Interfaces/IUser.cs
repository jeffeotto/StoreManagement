using System.Collections.Generic;
using API.Entities;

namespace API.Interfaces
{
    public interface IUser
    {
        public string UserName { get; set; }
        public List<Order> OrderList { get; set; }
    }
}