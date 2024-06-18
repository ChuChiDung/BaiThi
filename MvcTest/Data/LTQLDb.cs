using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTest.Models;

    public class LTQLDb : DbContext
    {
        public LTQLDb (DbContextOptions<LTQLDb> options)
            : base(options)
        {
        }

        public DbSet<MvcTest.Models.Person> Person { get; set; } = default!;
        public DbSet<MvcTest.Models.Student> Student { get; set; } = default!;
    }
