using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
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
