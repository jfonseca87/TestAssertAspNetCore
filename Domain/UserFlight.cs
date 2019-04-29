using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("UserFlight")]
    public class UserFlight
    {
        public UserFlight()
        {
            UserFlightRegister = new HashSet<UserFlightRegister>();
        }

        [Key]
        public int IdUser { get; set; }
        public string DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<UserFlightRegister> UserFlightRegister { get; set; }
    }
}
