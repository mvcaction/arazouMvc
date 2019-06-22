﻿using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPositive { get; set; }

        public ICollection<Transaction> Transaction { get; set; }
    }
}
