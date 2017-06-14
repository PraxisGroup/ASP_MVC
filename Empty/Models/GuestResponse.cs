using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name !")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your email")]
        [RegularExpression(@".+\@.+\..+",ErrorMessage ="Please enter a valid email adress!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter you phone number!")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you'll attend!")]
        public bool? WillAttend { get; set; }
    }
}