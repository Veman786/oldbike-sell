using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MCproject.Models
{
    public class bikeee
    {
        public int ID { get; set; }
        public make Make { get; set; }
        public int MakeID { get; set; }
        public models Model { get; set; }
        public  int ModelID { get; set;}
        [Required]
        public int year { get; set; }
        [Required]
        public int Mileage { get; set; }
        public string Features { get; set; }

        [Required(ErrorMessage ="Provide sellerNmae")]
        public string SellerName { get; set; }
        [Required]
        public int price { get; set; }
        public string  currency { get; set; }
        public string Imagepath { get; set; }
    }
}
