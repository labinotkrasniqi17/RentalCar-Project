using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RentalCar.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {

     public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }




    }
}



/*
 
   public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rentals { get; set; }


        public DbSet<Brand> Brands { get; set; }

    }
 
 
 
 */