﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales.Models;

namespace Sales.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext (DbContextOptions<SalesContext> options)
            : base(options)
        {
        }

        public DbSet<Sales.Models.Salesman> Salesman { get; set; } = default!;

        public DbSet<Sales.Models.Sale>? Sale { get; set; }
    }
}
