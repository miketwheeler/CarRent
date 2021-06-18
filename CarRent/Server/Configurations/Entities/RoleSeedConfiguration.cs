using CarRent.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = "893025bd-361a-440f-bced-a71212c43a21",
                   Name = "User",
                   NormalizedName = "USER"
               },
               new IdentityRole
               {
                   Id = "b0454334-3109-418b-966d-63c901b9865b",
                   Name = "Administrator",
                   NormalizedName = "ADMINISTRATOR"
               }
           );
        }
    }
}
