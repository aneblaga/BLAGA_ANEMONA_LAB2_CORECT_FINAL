using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BLAGA_ANEMONA_LAB2.Models;

namespace BLAGA_ANEMONA_LAB2.Data
{
    public class BLAGA_ANEMONA_LAB2Context : DbContext
    {
        public BLAGA_ANEMONA_LAB2Context (DbContextOptions<BLAGA_ANEMONA_LAB2Context> options)
            : base(options)
        {
        }

        public DbSet<BLAGA_ANEMONA_LAB2.Models.Book> Book { get; set; } = default!;

        public DbSet<BLAGA_ANEMONA_LAB2.Models.Publisher> Publisher { get; set; }
    }
}
