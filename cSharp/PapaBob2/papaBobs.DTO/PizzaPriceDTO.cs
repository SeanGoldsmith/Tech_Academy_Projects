﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papaBobs.DTO
{
    public class PizzaPriceDTO
    {
        public int Id { get; set; }
        public decimal SmallSizeCost { get; set; }
        public decimal MediumSizeCost { get; set; }
        public decimal LargeSizeCost { get; set; }
        public decimal ThickCrustCost { get; set; }
        public decimal ThinCurstCost { get; set; }
        public decimal RegularCrustCost { get; set; }
        public decimal SauasgeCost { get; set; }
        public decimal PepperoniCost { get; set; }
        public decimal OnionCost { get; set; }
        public decimal GreenPepperCost { get; set; }
    }
}
