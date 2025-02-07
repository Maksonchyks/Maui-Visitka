using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Visitka.Domain.Models;

namespace Visitka.Persistence.EntityTypeConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);
            builder.HasIndex(u => u.UserId).IsUnique();

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(128);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.Role)
                .IsRequired()
                .HasMaxLength(20)
                .HasConversion<string>();

            builder.Property(u => u.CreatedAt)
                .IsRequired();


        }
    }
}
