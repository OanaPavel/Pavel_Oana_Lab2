using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pavel_Oana_Lab2.Models;

namespace Pavel_Oana_Lab2.Data
{
    public class Pavel_Oana_Lab2Context : DbContext
    {
        public Pavel_Oana_Lab2Context (DbContextOptions<Pavel_Oana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pavel_Oana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Pavel_Oana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Pavel_Oana_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Pavel_Oana_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
