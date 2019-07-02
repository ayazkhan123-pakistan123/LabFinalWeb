using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabFinalWeb.Models
{
    public class Sales
    {
        [Key]
        public int SalesId { get; set; }
        //[ForeignKey("TyresId")]
        public int TyresId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [RegularExpression(@"^(\d{4})-((0[1-9])|(1[0-2]))-(0[1-9]|[12][0-9]|3[01])$",
                            ErrorMessage = "Date and Time is not valid")]
        public string TransactionDateTime { get; set; }
        [Required]
        public int CashRecieved { get; set; }
        
    }
}