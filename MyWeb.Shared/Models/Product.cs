﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MyWeb.Shared.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? ProductCategoryId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}