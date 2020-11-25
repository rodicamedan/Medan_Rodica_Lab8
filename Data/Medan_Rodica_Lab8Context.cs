using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Medan_Rodica_Lab8.Models;

namespace Medan_Rodica_Lab8.Data
{
    public class Medan_Rodica_Lab8Context : DbContext
    {
        public Medan_Rodica_Lab8Context (DbContextOptions<Medan_Rodica_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Medan_Rodica_Lab8.Models.Book> Book { get; set; }

        public DbSet<Medan_Rodica_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Medan_Rodica_Lab8.Models.Category> Category { get; set; }
    }
}
