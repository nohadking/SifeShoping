﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{

    public partial class SampleDetail
    {
        public int Id { get; set; }

        public int? SampleId { get; set; }

        public string? Description { get; set; }

        public string? Unit { get; set; }

        public string? Reference { get; set; }
    }
}
