using Mc.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Data.Context
{
    public class MCContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public MCContext(DbContextOptions options) : base(options)
        {

        }
    }
}
