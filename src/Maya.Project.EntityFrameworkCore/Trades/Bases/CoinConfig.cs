using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maya.Project.Trades.Bases
{
    public class CoinConfig:IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder.ToTable("Coins", "Trade");
            builder.Property(x => x.Name).IsUnicode().HasMaxLength(200);
            builder.Property(x => x.Symbol).IsUnicode().HasMaxLength(30);
            builder.Property(x => x.Icon).IsUnicode().HasMaxLength(100);
            builder.Property(x => x.IsActive);
            
        }
    }
}
