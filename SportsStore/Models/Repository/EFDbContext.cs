﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SportsStore.Models.Repository
{
    public class EFDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}