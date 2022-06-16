using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoojinProject1.Models;

namespace SoojinProject1.Data
{
    public class SoojinProject1Context : DbContext
    {
        public SoojinProject1Context (DbContextOptions<SoojinProject1Context> options)
            : base(options)
        {
        }

        public DbSet<Project>? Project { get; set; }
        public DbSet<Message>? Messages { get; set; }

  
    }
}
