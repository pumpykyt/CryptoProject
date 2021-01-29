using CryptoProject.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoProject.Data
{
    public class EFContext : IdentityDbContext<User>
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }

        public DbSet<UserAdditionalInfo> UserAdditionalInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(u => u.UserAdditionalInfo)
                .WithOne(t => t.User)
                .HasForeignKey<UserAdditionalInfo>(q => q.Id);
            base.OnModelCreating(builder);
        }
    }
    
}
