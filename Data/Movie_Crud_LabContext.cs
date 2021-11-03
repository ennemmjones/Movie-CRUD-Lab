using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_Crud_Lab.Models;

namespace Movie_Crud_Lab.Data
{
    public class Movie_Crud_LabContext : DbContext
    {
        public Movie_Crud_LabContext (DbContextOptions<Movie_Crud_LabContext> options)
            : base(options)
        {
        }

        public DbSet<Movie_Crud_Lab.Models.Movie> Movie { get; set; }
    }
}
