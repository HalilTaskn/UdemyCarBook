﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sunject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
