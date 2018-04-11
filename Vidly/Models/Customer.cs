using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        // navigation property allows us to navigate from one type to another
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}