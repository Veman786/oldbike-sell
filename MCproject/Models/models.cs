using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCproject.Models
{
    public class models
    {
     

        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        public make make { get; set; }
        public int makeid { get; set; }
    }
}
 