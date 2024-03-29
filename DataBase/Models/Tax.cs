﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    internal class Tax
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double? CGST { get; set; }
        public double? SGST { get; set; }
        public double? IGST { get; set; }
        public ICollection<Item>? Items { get; set; }
    }
}
