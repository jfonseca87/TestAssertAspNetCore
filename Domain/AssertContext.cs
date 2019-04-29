using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class AssertContext : DbContext
    {
        public AssertContext(DbContextOptions<AssertContext> options)
            : base(options)
        {}

        public DbSet<UserFlight> UserFlight { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<UserFlightRegister> UserFlightRegister { get; set; }
    }
}
