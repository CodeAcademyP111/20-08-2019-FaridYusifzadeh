using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polo_TestSite.Models
{
    public class Welcome
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Image { get; set; }
      
    }
}
