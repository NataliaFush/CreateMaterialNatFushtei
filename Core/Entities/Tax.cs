using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Tax :ITax
    {
        public int Id { get; set; }
        public double? CGST { get; set; }
        public double? SGST { get; set; }
        public double? IGST { get; set; }
    }
}
