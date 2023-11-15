﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_153503_Kachanovskaya.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Category? Category { get; set; }
        public int Price { get; set; }
        public string? ImgPath { get; set; }

    }
}
