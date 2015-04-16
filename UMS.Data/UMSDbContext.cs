using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Common;
using UMS.Data;

namespace UMS.Data
{
    public class UMSDbContext:DbContext
    {
        public DbSet<Login> User { get; set; }
    }
}
