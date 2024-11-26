using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
