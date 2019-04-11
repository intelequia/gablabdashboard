﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GAB.LabDashboard.Web.Models.domain
{
    public class ResultsByCompany : AggregateBase
    {
        [DisplayName("Company")]
        public string CompanyName{ get; set; }
    }
}
