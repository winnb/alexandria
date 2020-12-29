using Library.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class AppDbContext_BW : DbContext
    {
        public AppDbContext_BW(DbContextOptions<AppDbContext_BW> options)
            : base(options)
        {
        }

        public DbSet<Book_BW> Books { get; set; }
    }
}
