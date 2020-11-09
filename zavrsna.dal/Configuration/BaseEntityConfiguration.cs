using zavrsna.dal.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace zavrsna.dal.Configuration
{
      public abstract class BaseEntitityConfiguration<TEntitity> : IEntityTypeConfiguration<TEntitity> where TEntitity : BaseEntitity
    {
        public virtual void Configure(EntityTypeBuilder<TEntitity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ModifiedAt)
                .HasComment("This is the default comment.");
        }
    }

    public class BaseEntitity
    {
        internal object ModifiedAt;

        public object Id { get; internal set; }
    }
}
