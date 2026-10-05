using System;
using System.Collections.Generic;
using System.Text;

namespace TalebElm.Infrastructure.Persistence
{
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedAt)
                .IsRequired();
        }
    }
}
