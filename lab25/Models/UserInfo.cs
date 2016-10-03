using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab25.Models
{
    public class UserInfo
    {
        [Required]
        [StringLength(20, ErrorMessage = "Your name must be 1 - 20 characters long.", MinimumLength = 1)]
        public string Name { get; set; }
        [Required]
        [Range(1,150,ErrorMessage = "Age must be 1-150")]
        public int Age { get; set; }
    }
}