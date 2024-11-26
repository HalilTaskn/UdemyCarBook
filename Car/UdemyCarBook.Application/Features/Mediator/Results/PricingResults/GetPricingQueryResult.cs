using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Results.PricingResults
{
    public class GetPricingQueryResult
    {
        [Key]
        public int PricigID { get; set; }
        public string Name { get; set; }
    }
}
