using System;
using System.Collections.Generic;
using System.Text;
using CQRS.Responses;
using MediatR;

namespace CQRS.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderResponse>
    {
        public int Id { get; set; }

        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
