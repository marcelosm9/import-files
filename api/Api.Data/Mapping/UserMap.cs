using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            //Table
            builder.ToTable("User");
            //Key
            builder.HasKey(k => k.Id);
            //Index
            builder.HasIndex(i => i.Email)
                .IsUnique();
            //Properties
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(p => p.Email)
                .HasMaxLength(100);
            builder.Property(p => p.Birthday);
            builder.Property(p => p.Gender);
        }
    }
}
