﻿using System;
using System.Collections.Generic;

namespace FileTrackingSystem.AutoGeneratedCode
{
    public partial class Subject
    {
        public Subject()
        {
            Inwards = new HashSet<Inward>();
            Outwards = new HashSet<Outward>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SubName { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Inward> Inwards { get; set; }
        public virtual ICollection<Outward> Outwards { get; set; }
    }
}
