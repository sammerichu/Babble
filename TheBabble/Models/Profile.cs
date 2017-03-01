using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheBabble.Models
{
    public class Profile
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string About { get; set; }
        public string CommentForm { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}