﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.FeatureQueries;
using UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;


namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAddressHandler
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery , List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
               Phone=x.Phone,
               FooterAddressID=x.FooterAddressID,
               Address=x.Address,
               Description=x.Description,
               Email=x.Email,
            }).ToList();
        }
    }
}
