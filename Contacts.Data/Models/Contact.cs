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
        // pasirasyti kad rasytu su +3706  pattern="[+]370\d{8}|86\d{7}"  
        public string Phone { get; set; }
    }
}