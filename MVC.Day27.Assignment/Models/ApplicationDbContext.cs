﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Day27.Assignment.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("EclerxConn")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}