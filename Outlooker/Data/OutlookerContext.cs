using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Outlooker.Data
{
    public class OutlookerContext : DbContext
    {
        public OutlookerContext() : base("DefaultConnection")
        {

        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }

    }
}