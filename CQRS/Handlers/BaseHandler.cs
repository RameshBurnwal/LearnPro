using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MediatR;
using RameshWorkBook.DAL.DBContext;

namespace CQRS.Handlers
{
    public class BaseHandler
    {
        public WorkBookDBContext WorkBookDbContext { get; set; }
        public IMediator Mediator { get; set; }

        public IMapper WorkBookMapper { get; set; }
        public BaseHandler(WorkBookDBContext dbContext, IMediator iMediator, IMapper mapper)
        {
            this.WorkBookDbContext = dbContext;
            this.Mediator = iMediator;
            this.WorkBookMapper = mapper;

        }

    }
}
