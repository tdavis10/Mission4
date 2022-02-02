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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName="Action/Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );



            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieID = 1,
                    CategoryId = 2,
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
                    CategoryId = 1,
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
                    CategoryId = 4,
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
