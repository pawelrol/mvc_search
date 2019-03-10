using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    interface ISearchRepository
    {
        List<Orders> SearchForOrders(Orders order);
        

        
    }
}
