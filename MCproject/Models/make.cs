using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCproject.Models
{
    public class make
    {
      //  public static string Name { get; internal set; }
       // public static string Id { get; internal set; }
        public int id{ get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }

    }
}
