using System;
using System.Collections.Generic;
using System.Text;
using RameshWorkBook.DAL.Entity;

namespace CQRS.Responses
{
    public class OrdersResponse
    {
        public List<Order> Orders { get; set; }

    }
}
