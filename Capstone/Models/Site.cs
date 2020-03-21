﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Models
{
    public class Site
    {
        public int SiteID { get; set; }
        public int CampgroundID { get; set; }
        public int SiteNumber { get; set; }
        public int MaxOccupancy { get; set; }
        public int Accessible { get; set; } //may need to change to a bool
        public int MaxRVLenght { get; set; }
        public int Utilities { get; set; } //may need to change to a bool
        public decimal Cost { get; set; }

    }
}
