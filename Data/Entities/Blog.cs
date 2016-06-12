using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [Display(Name ="Positive Comments")]
        public string PostiveComments {get; set;}
        [Display(Name ="Negative Comments")]
        public string NegativeComments {get; set;}
        public virtual ICollection<Comment> Comments { get; set; }
    }
}