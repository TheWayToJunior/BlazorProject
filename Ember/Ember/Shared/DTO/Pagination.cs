﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ember.Shared
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;

        public int QuantityPerPage { get; set; } = 5;
    }
}