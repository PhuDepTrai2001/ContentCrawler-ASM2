using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentCrawler
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("CrawReceivebcontext")
        {

        }
        public DbSet<Info> Infos { get; set; }
    }
}
