using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using J4.Models;

namespace J4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<J4.Models.Recipes> Recipes { get; set; }
        public DbSet<J4.Models.Contest> Contest { get; set; }
        public DbSet<J4.Models.Announcenment> Announcenment { get; set; }
       
    }
}
