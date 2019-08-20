using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polo_TestSite.Models
{
    public class What_We
    {
        public int Id { get; set; }
        [Required, StringLength(1500)]
        public string Title { get; set; }
        [Required, StringLength(200)]
        public string Descript { get; set; }
    }
}
