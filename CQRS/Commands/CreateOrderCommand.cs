using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CQRS.Commands
{
    public class CreateOrderCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
