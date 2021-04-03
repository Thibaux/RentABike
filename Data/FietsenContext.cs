using Microsoft.EntityFrameworkCore;
using BikesRent.Models;

namespace BikesRent.Data
{
    public class MvcBikesContext : DbContext
    {
        public MvcBikesContext(DbContextOptions<MvcBikesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBikesContext> Bike { get; set; }
    }
}