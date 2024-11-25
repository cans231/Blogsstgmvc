using Blogsstgmvc.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blogsstgmvc.DAL.Context
{
    public class BlogsstgmvcDbContext : DbContext
    {
        protected BlogsstgmvcDbContext() 
        {

        }
        public BlogsstgmvcDbContext(DbContextOptions<BlogsstgmvcDbContext> options) : base(options) 
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }




    }
}
