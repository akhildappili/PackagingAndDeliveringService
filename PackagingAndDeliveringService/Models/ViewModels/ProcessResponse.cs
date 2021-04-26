﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDeliveringService.Models.ViewModels
{
    public class ProcessResponse
    {
        public int RequestId { get; set; }
        public double? ProcessingCharge { get; set; }
        public double? PackagingAndDeliveryCharge { get; set; }
        public DateTime? DateofDelivery { get; set; }
    }
}
