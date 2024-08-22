using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementWEBAPI.Model
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
