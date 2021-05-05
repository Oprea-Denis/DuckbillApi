using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DuckbillApi.Models;

namespace DuckbillApi.Data
{
    public class DuckbillApiContext : DbContext
    {
        public DuckbillApiContext (DbContextOptions<DuckbillApiContext> options)
            : base(options)
        {
        }

        public DbSet<DuckbillApi.Models.Duckbill> Duckbill { get; set; }
    }
}
