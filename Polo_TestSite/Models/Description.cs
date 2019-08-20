using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polo_TestSite.Models
{
    public class Description
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Title { get; set; }
        [Required, StringLength(400)]
        public string Descript { get; set; }

    }
}
