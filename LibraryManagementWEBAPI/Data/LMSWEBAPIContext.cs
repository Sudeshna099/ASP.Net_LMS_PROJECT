using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagementWEBAPI.Model;

namespace LibraryManagementWEBAPI.Data
{
    public class LMSWEBAPIContext : DbContext
    {
        public LMSWEBAPIContext (DbContextOptions<LMSWEBAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
