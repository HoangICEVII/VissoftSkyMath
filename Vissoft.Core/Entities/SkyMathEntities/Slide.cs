﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Slide
    {
        public int Id { get; set; }
        public string ImageLink { get; set; } = string.Empty;
        public string Slogan { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
