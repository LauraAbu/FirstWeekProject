using System.ComponentModel.DataAnnotations;

namespace FirstWeekProject.Data.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 5)]
        //[RegularExpression("")]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
    }
}