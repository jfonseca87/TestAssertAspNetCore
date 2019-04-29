using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("UserFlightRegister")]
    public class UserFlightRegister
    {
        [Key]
        public int IdUserFlightRegister { get; set; }
        public int IdUser { get; set; }
        public int IdFlight { get; set; }

        public UserFlight UserFlight { get; set; }
        public Flight Flight { get; set; }
    }
}
