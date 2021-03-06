﻿using System;

namespace ZPastel.Model
{
    public class User
    {
        public long Id { get; set; }
        public string FirebaseId { get; set; }
        public long CreatedById { get; set; }
        public long LastModifiedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
    }
}
