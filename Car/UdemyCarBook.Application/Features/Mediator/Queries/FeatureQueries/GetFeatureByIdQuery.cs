﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery :IRequest<GetFeaturByIdQueryResult>
    {
        public int  Id { get; set; }
    
        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }
    }
}
