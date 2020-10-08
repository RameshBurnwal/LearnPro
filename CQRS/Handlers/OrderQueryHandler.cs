using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CQRS.Mappers;
using CQRS.Queries;
using CQRS.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RameshWorkBook.DAL.DBContext;
using RameshWorkBook.DAL.Entity;

namespace CQRS.Handlers
{
    public class OrderQueryHandler : BaseHandler, IRequestHandler<GetOrderByIdQuery, OrderResponse>
    {
        public OrderQueryHandler(WorkBookDBContext dbContext, IMediator mediator, IMapper mapper) : base(dbContext, mediator, mapper)
        {
        }
        public async Task<OrderResponse> Handle(GetOrderByIdQuery message, CancellationToken cancellationToken)
        {
            Order response = await WorkBookDbContext.Orders.FirstOrDefaultAsync(order => order.Id == message.Id, cancellationToken);
            var data = WorkBookMapper.Map<OrderResponse>(response);
            return data;
        }
    }
}
