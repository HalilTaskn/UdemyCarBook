using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CarDescription
    {
        [Key]
        public int CarDescripionID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public string Details { get; set; }
    }
}
