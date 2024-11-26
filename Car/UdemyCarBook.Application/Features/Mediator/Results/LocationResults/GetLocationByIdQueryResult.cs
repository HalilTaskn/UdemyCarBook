﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Results.LocationResults
{
    public class GetLocationByIdQueryResult
    {
        [Key]
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}
