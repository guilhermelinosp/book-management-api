using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.Management.Infrastructure.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Domain.Entities.Book>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Book> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
