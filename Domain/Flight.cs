using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Flight")]
    public class Flight
    {
        public Flight()
        {
            UserFlightRegister = new HashSet<UserFlightRegister>();
        }

        [Key]
        public int IdFlight { get; set; }
        public string SourceCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string PlaneNumber { get; set; }
        public string PilotName { get; set; }

        public ICollection<UserFlightRegister> UserFlightRegister { get; set; }
    }
}
