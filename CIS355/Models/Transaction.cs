using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;

namespace CIS355.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public virtual ApplicationUser User{ get; set; }
        public virtual Actvity Actvity { get; set; }
        public bool IsVerified { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
    }
}