using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    interface ISearchLogic
    {
        List<Orders> SearchForOrders(DateTime orderDate);
    }
}
