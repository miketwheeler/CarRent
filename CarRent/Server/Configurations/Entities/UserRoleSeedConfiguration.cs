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
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "893025bd-361a-440f-bced-a71212c43a21",
                   UserId = "500d8c74-42ae-42b9-a3cb-d62aa74d42dc"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "b0454334-3109-418b-966d-63c901b9865b",
                   UserId = "0c69f883-6a25-4cbe-9866-98e4ffaa91f8"
               }
           );
        }
    }
}
