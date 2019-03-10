using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DataLayer.Models;

namespace BusinessLayer
{
    public class SearchLogic : ISearchLogic
    {
        public List<Orders> SearchForOrders(DateTime orderDate)
        {
            SearchRepository repo = new SearchRepository();
            Orders o = new Orders() { OrderDate = orderDate };
            return repo.SearchForOrders(o);

        }
    }
}
