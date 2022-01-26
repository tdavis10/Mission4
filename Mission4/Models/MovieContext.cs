using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave Blank for Now
        }

        public DbSet<MovieResponse> MovieResponses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieID = 1,
                    Category = "Comedy",
                    Title = "Hot Rod",
                    Year = 2007,
                    Director = "Akiva Shaffer",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "My name is Rod"
                },

                new MovieResponse
                {
                    MovieID = 2,
                    Category = "Action/Sci-Fi",
                    Title = "Star Wars: Return of the Jedi",
                    Year = 1983,
                    Director = "Richard Marquand",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "Brett",
                    Notes = "Hit it Chewy!"
                },

                new MovieResponse
                {
                    MovieID = 3,
                    Category = "Family/Adventure",
                    Title = "Finding Nemo",
                    Year = 2003,
                    Director = "Andrew Stanton",
                    Rating = "G",
                    Edited = false,
                    LentTo = "Conner",
                    Notes = "Wallaby Way Sydney"
                }

            );
        }
    }

    
}
