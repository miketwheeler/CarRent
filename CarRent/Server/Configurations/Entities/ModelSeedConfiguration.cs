using CarRent.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
               new Model
               {
                   Id = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "Supra",
                   UpdateBy = "System"
               },
               new Model
               {
                   Id = 2,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "RAV-4",
                   UpdateBy = "System"
               },
               new Model
               {
                   Id = 3,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "i435",
                   UpdateBy = "System"
               },
               new Model
               {
                   Id = 4,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "X5",
                   UpdateBy = "System"
               }
           );
        }
    }
}
