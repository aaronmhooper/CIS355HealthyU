using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS355.Models
{
    public class TransactionViewModel
    {
        public Transaction Transaction { get; set; }
        public int SelectedActivity { get; set; }
        public SelectList Activities { get; set; }
    }
}