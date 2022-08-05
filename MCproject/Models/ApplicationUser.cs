using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MCproject.Models
{
    public class ApplicationUser: IdentityUser
    {
        [DisplayName("Alternative Phone")]
        public string Phonenumber2 { get; set; }
        public string Gender { get; set; }
        [NotMapped]//IF we use not mapped this field not saved in database
        public bool IsAdmin { get; set; }
    }
}
