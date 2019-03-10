using System;
using System.Collections.Generic;
using System.Text;
using WebNorth.Models;

namespace WebNorth.Repository

{
    interface ISearchRepository
    {
        List<Orders> SearchForOrders(Orders order);
        

        
    }
}
