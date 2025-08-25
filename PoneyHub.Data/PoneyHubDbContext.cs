using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoneyHub.Data
{
    public class PoneyHubDbContext : DbContext
    {
        public PoneyHubDbContext(
            DbContextOptions<PoneyHubDbContext> options) : base(options)
        {
        }
    }
}