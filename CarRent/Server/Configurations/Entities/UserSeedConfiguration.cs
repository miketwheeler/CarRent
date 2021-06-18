using CarRent.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
               new ApplicationUser
               {
                   Id = "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                   Email = "admin@localhost.com",
                   NormalizedEmail = "ADMIN@LOCALHOST.COM",
                   FirstName = "System",
                   LastName = "Admin",
                   UserName = "admin@localhost.com",
                   NormalizedUserName = "ADMIN@LOCALHOST.COM",
                   PasswordHash = hasher.HashPassword(null, "P@ssword1")
               },
               new ApplicationUser
               {
                   Id = "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                   Email = "user@localhost.com",
                   NormalizedEmail = "USER@LOCALHOST.COM",
                   FirstName = "System",
                   LastName = "User",
                   UserName = "user@localhost.com",
                   NormalizedUserName = "USER@LOCALHOST.COM",
                   PasswordHash = hasher.HashPassword(null, "P@ssword1")
               }
           );
        }
    }
}
