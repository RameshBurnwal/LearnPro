using System;
using System.Collections.Generic;
using System.Text;
using CQRS.Responses;
using MediatR;
using RameshWorkBook.DAL.Entity;

namespace CQRS.Queries
{
    public class GetAllOrderQuery : IRequest<OrdersResponse>
    {
       
    }
}
