﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public enum Status
    {
        Created_waiting,
        Formed,
        Processed,
        Accepted,
        Canceled,
        Failed,
        Succeeded
    }
}