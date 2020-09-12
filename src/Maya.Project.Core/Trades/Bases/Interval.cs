using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace Maya.Project.Trades.Bases
{
    public class Interval:Entity<int>
    {
        public string Name { get; protected set; }
        public string Symbol { get; protected set; }
        public bool IsActive { get; protected set; }
        

        public Interval(string name,bool isActive)
        {
            Name = name;
            IsActive = isActive;
        }
        protected Interval(){}
    }
}
