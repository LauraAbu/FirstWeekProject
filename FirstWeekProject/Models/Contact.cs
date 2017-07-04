using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWeekProject.Models
{
    public class Contact
    {
        [Required]
        [StringLength(255, MinimumLength = 10)]
        //[RegularExpression("")]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
    }
}