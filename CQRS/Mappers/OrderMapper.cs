using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CQRS.Responses;
using MediatR;
using RameshWorkBook.DAL.Entity;

namespace CQRS.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Order,OrderResponse>();
            CreateMap<List<Order>, List<OrderResponse>>();
            CreateMap<Order, int>();
        }
    }
}
