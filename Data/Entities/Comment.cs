using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class Comment
    {
        [Key]
        public int ID { get; set; }
        public Blog Blog { get; set; }
        [ForeignKey("Blog")]
        public int BlogID { get; set; }
        public string Text { get; set; }
    }
}
