using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RentalCar.Data.Static;
using RentalCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalCar.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Clients
                if (!context.Contacts.Any())
                {
                    context.Contacts.AddRange(new List<Contact>()
                    {
                        new Contact()
                        {
                              //Id
                              FullName = "Test",
                              Email  = "test@ubt-uni.net",
                              Subject = "2222",
                              Message = "Some Place",
                        },
                        new Contact()
                        {
                              //Id
                              FullName = "Test",
                              Email  = "test@ubt-uni.net",
                              Subject = "2222",
                              Message = "Some Place",
                        }

                    });
                    context.SaveChanges();
                }
                //Rentals
                if (!context.Rentals.Any())
                {
                    context.Rentals.AddRange(new List<Rental>()
                    {
                        new Rental()
                        {
                            Logo = "https://c7.alamy.com/comp/T8P429/vector-logo-for-car-rental-and-sales-T8P429.jpg",
                            Name = "Rent Kosova",
                            Address = "Prishtinë, Kosovë",
                            Mobile = 49111222,
                            Description = "RentKosova is the best Rent in town that you can drive best cars in Kosovo"

                        },
                         new Rental()
                        {
                            Logo = "https://c7.alamy.com/comp/T8P3YT/vector-logo-for-car-rental-and-sales-T8P3YT.jpg",
                            Name = "Besiana Rent",
                            Address = "Podujevë, Kosovë",
                            Mobile = 49222333,
                            Description = "Besiana Rent is the best rent in Podujevë with new cars"

                        },
                          new Rental()
                        {
                            Logo = "https://c7.alamy.com/comp/T8P3YT/vector-logo-for-car-rental-and-sales-T8P3YT.jpg",
                            Name = "Krasniqi Rent",
                            Address = "Podujevë, Kosovë",
                            Mobile = 49222333,
                            Description = "Krasniqi Rent is the best rent in Prishtina with new cars"

                        },
                           new Rental()
                        {
                            Logo = "https://c7.alamy.com/comp/T8P3YT/vector-logo-for-car-rental-and-sales-T8P3YT.jpg",
                            Name = "Ismajli Rent",
                            Address = "Shtime, Kosovë",
                            Mobile = 49222333,
                            Description = "Ismajli Rent is the best rent in Shtime with almost all models founded"

                        }, new Rental()
                        {
                            Logo = "https://c7.alamy.com/comp/T8P3YT/vector-logo-for-car-rental-and-sales-T8P3YT.jpg",
                            Name = "Llapi Rent",
                            Address = "Podujevë, Kosovë",
                            Mobile = 49222333,
                            Description = "Llapi Rent is the most popular rent in Podujevë with new cars"

                        },
                            new Rental()
                        {
                            Logo = "https://c7.alamy.com/comp/T8P3YT/vector-logo-for-car-rental-and-sales-T8P3YT.jpg",
                            Name = "Auto Rent Beka",
                            Address = "Podujevë, Kosovë",
                            Mobile = 49222333,
                            Description = "Auto Rent Beka is the best rent in Podujevë with new cars"

                        }

                    });
                    context.SaveChanges();
                }

                //Brand
                if (!context.Brands.Any())
                {
                    context.Brands.AddRange(new List<Brand>()
                    {
                        new Brand()
                        {
                            FullName = "Mercedes Benz",
                            Bio = "The best company fort strong cars and Luxury",
                            ProfilePictureURL = "https://logodownload.org/wp-content/uploads/2014/04/mercedes-benz-logo-0.png"

                        },
                        new Brand()
                        {
                            FullName = "BMW",
                            Bio = "Great Company are known for fast and shifty Cars",
                            ProfilePictureURL = "https://logowik.com/content/uploads/images/849_bmw.jpg"
                        },
                        new Brand()
                        {
                            FullName = "Audi",
                            Bio = "German Company durability is in their Cars",
                            ProfilePictureURL = "https://logowik.com/content/uploads/images/t_562_audi.jpg"
                        },
                        new Brand()
                        {
                            FullName = "Volkswagen",
                            Bio = "Biggest company in europe long living cars",
                            ProfilePictureURL = "https://logowik.com/content/uploads/images/449_volkswagen.jpg"
                        },
                        new Brand()
                        {
                            FullName = "Opel",
                            Bio = "Economic cars",
                            ProfilePictureURL = "https://brandlogos.net/wp-content/uploads/2013/04/opel-2002-eps-vector-logo.png"
                        }
                    });
                    context.SaveChanges();
                }

                //Cars

                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(new List<Car>()
                    {
                        new Car()
                        {

                              Name = "Vetura1",
                              Description  = "Description Vetura1",
                              Price = 25,
                              ImageURL = "https://elitetraveler.com/wp-content/uploads/2019/07/Screenshot-2020-05-12-at-15.10.34.png",
                              StartDate= DateTime.Now.AddDays(-10),
                              EndDate = DateTime.Now.AddDays(-5),
                              RentalId=1,
                              BrandId=1,
                              CarCategory=CarCategory.Sport
                        },
                       new Car()
                        {

                              Name = "Vetura2",
                              Description  = "Description Vetura2",
                              Price = 30,
                              ImageURL = "https://elitetraveler.com/wp-content/uploads/2019/07/Screenshot-2020-05-12-at-15.10.34.png",
                              StartDate= DateTime.Now.AddDays(-10),
                              EndDate = DateTime.Now.AddDays(-5),
                              RentalId=2,
                              BrandId=2,
                              CarCategory=CarCategory.Hatchback
                        },
                        new Car()
                        {

                              Name = "Vetura3",
                              Description  = "Description Vetura3",
                              Price = 20,
                              ImageURL = "https://elitetraveler.com/wp-content/uploads/2019/07/Screenshot-2020-05-12-at-15.10.34.png",
                              StartDate= DateTime.Now.AddDays(-10),
                              EndDate = DateTime.Now.AddDays(-5),
                              RentalId=2,
                              BrandId=3,
                              CarCategory=CarCategory.Convertible
                        },
                         new Car()
                        {

                              Name = "Vetura4",
                              Description  = "Description Vetura4",
                              Price = 30,
                              ImageURL = "https://elitetraveler.com/wp-content/uploads/2019/07/Screenshot-2020-05-12-at-15.10.34.png",
                              StartDate= DateTime.Now.AddDays(-10),
                              EndDate = DateTime.Now.AddDays(-5),
                              RentalId=4,
                              BrandId=4,
                              CarCategory=CarCategory.Convertible
                        },
                    });
                    context.SaveChanges();




                }

            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles Section
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //User section
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var adminUser = await userManager.FindByEmailAsync("admin@ubt-uni.net");
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Application Admin",
                        UserName = "app-admin",
                        Email = "admin@ubt-uni.net",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);

                }
                var appUser = await userManager.FindByEmailAsync("user@ubt-uni.net");
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = "user@ubt-uni.net",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
