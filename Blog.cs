using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogEngine.Models
{
    public class Blog
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required, StringLength(50)]
        public string Author { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}