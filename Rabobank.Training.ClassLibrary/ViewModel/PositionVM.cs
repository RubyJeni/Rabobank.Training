﻿using System;
using System.Collections.Generic;

namespace Rabobank.Training.ClassLibrary.ViewModel
{
    public class PositionVM
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public List<MandateVM> Mandates { get; set; }
    }
}
