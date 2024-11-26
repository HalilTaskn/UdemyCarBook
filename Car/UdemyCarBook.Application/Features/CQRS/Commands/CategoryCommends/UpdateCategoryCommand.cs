using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommends
{
    public class UpdateCategoryCommand
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}

