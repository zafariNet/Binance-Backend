﻿using System.Collections.Generic;

namespace Maya.Project.EntityDynamicParameterValues.Dto
{
    public class InsertOrUpdateAllValuesInput
    {
        public List<InsertOrUpdateAllValuesInputItem> Items { get; set; }
    }

    public class InsertOrUpdateAllValuesInputItem
    {
        public string EntityId { get; set; }

        public int EntityDynamicParameterId { get; set; }

        public List<string> Values { get; set; }
    }
}