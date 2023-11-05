using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeCraftersApp.Models;

namespace CodeCraftersApp.Data
{
    public class CodeCraftersAppContext : DbContext
    {
        public CodeCraftersAppContext (DbContextOptions<CodeCraftersAppContext> options)
            : base(options)
        {
        }

        public DbSet<CodeCraftersApp.Models.Course> Course { get; set; } = default!;

        public DbSet<CodeCraftersApp.Models.Application> Application { get; set; } = default!;
    }
}
