﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetECommerce.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
    }
}