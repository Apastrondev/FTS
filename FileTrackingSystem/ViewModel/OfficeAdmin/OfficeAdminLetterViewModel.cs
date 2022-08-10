﻿using DataLayer.AutoGeneratedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTrackingSystem.ViewModel.OfficeAdmin
{
    public class OfficeAdminLetterViewModel
    {
        public List<Letter> Letters { get; set; }
        public string? Type { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
