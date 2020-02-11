﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }

        public string Img { get; set; }

        public ushort Price { get; set; }

        public bool IsFavourite { get; set; }          // Best selling products

        public bool Avaliable { get; set; }

        public int CatId { get; set; }

        public virtual Category Category { get; set; }
    }
}
