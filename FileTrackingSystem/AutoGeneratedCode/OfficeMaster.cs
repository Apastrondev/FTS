﻿using System;
using System.Collections.Generic;

namespace FileTrackingSystem.AutoGeneratedCode
{
    public partial class OfficeMaster
    {
        public OfficeMaster()
        {
            InverseOffice = new HashSet<OfficeMaster>();
        }

        public int Id { get; set; }
        public string? OfficeName { get; set; }
        public string? Address { get; set; }
        public string? Taluka { get; set; }
        public string? District { get; set; }
        public string? Contact1 { get; set; }
        public string? Contact2 { get; set; }
        public string? Email { get; set; }
        public bool? IsActive { get; set; }
        public int? OfficeTypeId { get; set; }
        public int? RegionalOfficeId { get; set; }
        public int? Ddocode { get; set; }
        public int? PinCode { get; set; }
        public string? Fax { get; set; }
        public string? WebSite { get; set; }
        public int? OfficeId { get; set; }
        public string? Village { get; set; }
        public string? ContactPersonName { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual OfficeMaster? Office { get; set; }
        public virtual OfficeType? OfficeType { get; set; }
        public virtual ICollection<OfficeMaster> InverseOffice { get; set; }
    }
}