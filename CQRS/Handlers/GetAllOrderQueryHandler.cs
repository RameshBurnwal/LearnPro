using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CQRS.Queries;
using CQRS.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RameshWorkBook.DAL.DBContext;
using RameshWorkBook.DAL.Entity;

namespace CQRS.Handlers
{
    public class GetAllOrderQueryHandler : BaseHandler, IRequestHandler<GetAllOrderQuery, OrdersResponse>
    {
        public GetAllOrderQueryHandler(WorkBookDBContext dbContext, IMediator mediator, IMapper mapper) : base(dbContext, mediator, mapper)
        {
        }
        public async Task<OrdersResponse> Handle(GetAllOrderQuery message, CancellationToken cancellationToken)
        {
            var response = await WorkBookDbContext.Orders.ToListAsync(cancellationToken);
            var orders = new OrdersResponse {Orders = response};
            return orders;
        }
    }
}
