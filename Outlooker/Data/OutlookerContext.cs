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
            this.Configuration.LazyLoadingEnabled = false; //be careful of this and understand before implementing
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OutlookerContext, OutlookerMigrationsConfiguration>());
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }

    }
}