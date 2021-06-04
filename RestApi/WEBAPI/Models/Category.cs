﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WEBAPI.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public int CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
