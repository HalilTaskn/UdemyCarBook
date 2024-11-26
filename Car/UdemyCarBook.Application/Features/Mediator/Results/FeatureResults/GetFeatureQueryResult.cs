﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Results.FeatureResults
{
    public class GetFeatureQueryResult
    {
        [Key]
        public int FeatureID { get; set; }
        public string Name { get; set; }
    }
}
