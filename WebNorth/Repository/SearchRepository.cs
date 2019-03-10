using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebNorth.Models;

namespace WebNorth.Repository
{
    public class SearchRepository : ISearchRepository
    {
        public List<Orders> SearchForOrders(Orders order)
        {
            NORTHWNDContext db = new NORTHWNDContext();
            var result = db.Orders.Where(x => x.OrderDate == order.OrderDate).ToList();
            return result;
        }
    }
}
