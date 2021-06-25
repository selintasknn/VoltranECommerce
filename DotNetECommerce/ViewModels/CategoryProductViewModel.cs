using DotNetECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetECommerce.ViewModels
{
    public class CategoryProductViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}