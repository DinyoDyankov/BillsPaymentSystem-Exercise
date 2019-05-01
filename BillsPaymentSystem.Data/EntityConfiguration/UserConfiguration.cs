using BillsPaymentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(b => b.UserId);

            builder
                .Property(b => b.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(b => b.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(b => b.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(b => b.Password)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}