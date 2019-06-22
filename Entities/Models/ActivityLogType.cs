﻿using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class ActivityLogType
    {
        public ActivityLogType()
        {
            ActivityLog = new HashSet<ActivityLog>();
        }

        public int Id { get; set; }
        public string SystemKeyword { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

        public ICollection<ActivityLog> ActivityLog { get; set; }
    }
}
