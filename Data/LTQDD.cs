using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTTMBT.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<NTTMBT.Models.NTTM428Person> NTTM428Person { get; set; } = default!;

        public DbSet<NTTMBT.Models.NTTM428Student> NTTM428Student { get; set; } = default!;

        public DbSet<NTTMBT.Models.NTTM428Employee> NTTM428Employee { get; set; } = default!;
    }
