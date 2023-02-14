using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ev244.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    Category = "Action",
                    Title = "Mission Impossible 1",
                    Year = 1996,
                    Director = "Brian De Palma",
                    Rating = "PG-13",
                    Edited = true,
                    Lent_To = "Siko",
                    Notes = "First One"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    Category = "Action",
                    Title = "Mission Impossible 2",
                    Year = 2000,
                    Director = "John Woo",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Toko",
                    Notes = "Scratched"
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    Category = "Action",
                    Title = "Mission Impossible 3",
                    Year = 2006,
                    Director = "J. J. Abrams",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Loho",
                    Notes = "Yups"
                }
                );
        }
    }
}
