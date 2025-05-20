using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace reservepp

{

    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.DocID);

            builder.Property(u => u.Role)
                   .IsRequired();

            builder.HasDiscriminator<string>("Role")
                .HasValue<Officer>("Officer")
                .HasValue<Conscript>("Conscript")
                .HasValue<TCKEmployee>("TCKEmployee");
        }
    }
}
