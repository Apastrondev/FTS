using System;
using System.Collections.Generic;

namespace FileTrackingSystem.AutoGeneratedCode
{
    public partial class InwardOutward
    {
        public int Id { get; set; }
        public int? InwardId { get; set; }
        public int? OutwardId { get; set; }

        public virtual Inward? Inward { get; set; }
        public virtual Outward? Outward { get; set; }
    }
}
