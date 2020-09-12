using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Maya.Project.Trades.Bases
{
    public class Coin: Entity<int>
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }

    }
}
