using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITax
    {
        int Id { get; set; }
        double? CGST { get; set; }
        double? SGST { get; set; }
        double? IGST { get; set; }
    }
}
