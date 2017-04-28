using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS355.Models
{
    public class UserHomeViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int PointsTotal { get; set; }
    }
}