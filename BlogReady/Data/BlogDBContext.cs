using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogReady.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlogReady.Data
{
    public class BlogDBContext : IdentityDbContext
    {
        public BlogDBContext (DbContextOptions<BlogDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
       
        public DbSet<BlogReady.Models.BlogPost> BlogPost { get; set; } = default!;
    }
}
