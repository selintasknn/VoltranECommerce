﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public byte[] Image { get; set; }
        public virtual Category Category { get; set; }
    }
}