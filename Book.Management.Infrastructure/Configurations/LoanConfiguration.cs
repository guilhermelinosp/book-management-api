using Book.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.Management.Infrastructure.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(l => l.Id);

            builder.HasOne(u => u.User)
                .WithMany(b => b.Loans)
                .HasForeignKey(k => k.IdUser)
                .OnDelete(DeleteBehavior.Restrict);            
            
            builder.HasOne(u => u.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(k => k.IdBook)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
