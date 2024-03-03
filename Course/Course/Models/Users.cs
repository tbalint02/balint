using System.ComponentModel.DataAnnotations;

namespace Course.Models
{
    public class User
    {
        [Required]
        public int? Id { get; set; }
        [StringLength(10)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }   


    }
}
