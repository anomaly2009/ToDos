using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDos.Models;

namespace ToDos.Data
{
    public class ToDosContext : DbContext
    {
        public ToDosContext (DbContextOptions<ToDosContext> options)
            : base(options)
        {
        }

        public DbSet<ToDos.Models.Tasks> Tasks { get; set; } = default!;
    }
}
