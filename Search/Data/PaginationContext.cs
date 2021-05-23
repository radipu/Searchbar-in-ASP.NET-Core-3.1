using Microsoft.EntityFrameworkCore;
using Pagination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Data
{
    public class PaginationContext : DbContext
    {
        public PaginationContext(DbContextOptions<PaginationContext> options) : base (options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
