using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabFinalWeb.Models
{
    public class Tyres
    {
       
        [Key]
        public int TyresId { get; set; }
        [Required]

        public string Brand { get; set; }
        [Required]

        public string Country { get; set; }
        [Required]
        [RegularExpression(@"^(?=[\S\s]{1,10}$)[\S\s]*")]
        public int Size { get; set; }
        [Required]

        public string Condition { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Required]
       
        public int PurchasePrice { get; set; }
        [Required]

        public int SellingPrice { get; set; }
          
        
    }
}