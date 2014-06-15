using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using RequestsManager.Model;

namespace RequestsManager.Repository
{
    public class DBContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
    }
}
