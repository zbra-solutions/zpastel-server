﻿using System;
using System.Collections.Generic;

namespace ZPastel.Model
{
    public class Order
    {
        public long Id { get; set; }
        public decimal TotalPrice { get; set; }
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public string CreatedByUsername { get; set; }
        public long CreatedById { get; set; }
        public User User { get; set; }
        public DateTime CreatedOn { get; set; }
        public long LastModifiedById { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
