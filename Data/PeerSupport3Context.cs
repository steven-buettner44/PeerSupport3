using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeerSupport3.Models;

namespace PeerSupport3.Data
{
    public class PeerSupport3Context : DbContext
    {
        public PeerSupport3Context (DbContextOptions<PeerSupport3Context> options)
            : base(options)
        {
        }

        public DbSet<PeerSupport3.Models.Movie> Movie { get; set; }
    }
}
