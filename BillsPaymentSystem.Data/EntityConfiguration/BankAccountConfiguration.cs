using BillsPaymentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.EntityConfiguration
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder
                .HasKey(b => b.BankAccountId);

            builder
                .Property(b => b.BankName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(b => b.SWIFT)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}
