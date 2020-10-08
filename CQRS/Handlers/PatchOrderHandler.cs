using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CQRS.Commands;
using CQRS.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RameshWorkBook.DAL.DBContext;
using RameshWorkBook.DAL.Entity;

namespace CQRS.Handlers
{
    /*public class PatchOrderHandler : BaseHandler, IRequestHandler<PatchOrderCommand, OrderResponse>
    {
        public PatchOrderHandler(WorkBookDBContext dbContext, IMediator mediator) : base(dbContext, mediator)
        {
            
        }

        public async Task<OrderResponse> Handle(PatchOrderCommand command, CancellationToken cancellationToken)
        {
            var originalEntity =
                await WorkBookDbContext.Orders
                    .AsNoTracking()
                    .SingleOrDefaultAsync(x => x.Id == command.OrderId,
                        cancellationToken: cancellationToken);

            if (originalEntity == null)
                return null;

            var model = originalEntity.ToPatchModal();

            command.JsonPatchDocument.ApplyTo(model, error =>
            {
                Debug.WriteLine($"Failed to apply patch: this is where you add your logger");
            });

            //business rule example that all updated product should be suffixed with PROD if it had 'product' in the name and the new name does not
            if (originalEntity.Name.ToLower().Contains("product") && !model.Name.ToLower().Contains("product"))
            {
                model.Name = $"PROD: {model.Name}";
            }

            var updatedEntity = new Order
            {
                Id = originalEntity.Id,
                Name = model.Name
            };

            WorkBookDbContext.Update(updatedEntity);
            await WorkBookDbContext.SaveChangesAsync(cancellationToken);
            //await Mediator.Publish()

            var response = updatedEntity.ToResponse();
            return response;
        }
    }*/
}
