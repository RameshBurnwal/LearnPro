using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CQRS.Commands;
using CQRS.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RameshWorkBook.DAL.DBContext;
using RameshWorkBook.DAL.Entity;

namespace CQRS.Handlers
{
    public class CreateOrderCommandHandler : BaseHandler, IRequestHandler<CreateOrderCommand,int>
    {
        public CreateOrderCommandHandler(WorkBookDBContext dbContext, IMediator mediator, IMapper mapper) : base(dbContext, mediator, mapper)
        {
        }
        public async Task<int> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            var order = new Order {Name = command.Name};
            await WorkBookDbContext.Orders.AddAsync(order, cancellationToken);
            await WorkBookDbContext.SaveChangesAsync(cancellationToken);
            //await Mediator.Publish(new Order {Id = order.Id}, cancellationToken);
            return order.Id;
        }

    }
}
