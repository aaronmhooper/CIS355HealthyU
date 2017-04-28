using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CIS355.Models
{
    public class Actvity
    {
        public enum activityType { Strength, Excersize, Annual, Class }
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }
        public activityType Type { get; set; }
        public bool NeedsVerify { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}