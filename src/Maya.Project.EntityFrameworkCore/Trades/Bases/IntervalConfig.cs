using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maya.Project.Trades.Bases
{
    public class IntervalConfig:IEntityTypeConfiguration<Interval>
    {
        public void Configure(EntityTypeBuilder<Interval> builder)
        {
            builder.ToTable("Intervals", "Trade");
            builder.Property(x => x.Name).IsUnicode().HasMaxLength(500);
            builder.Property(x => x.Symbol).IsUnicode().HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
        }
    }
}
