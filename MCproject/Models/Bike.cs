using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCproject.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public make make { get; set; }
        public int makeid { get; set; }
        public models models { get; set; }
        public int modelid { get; set; }
        [Required]
         public int year { get; set; }
        [Required]

        public int mileage { get; set; }
        [Required]

        public string features { get; set; }
        [Required]

        public string sellername { get; set; }
        [Required]

        public string selleremail { get; set; }
        [Required]

        public string sellerphone { get; set; }
        [Required]

        public int price { get; set; }
        [Required]

        public string currency{ get; set; }
        [Required]

        public string imagepath { get; set; }
        

        }
    }

