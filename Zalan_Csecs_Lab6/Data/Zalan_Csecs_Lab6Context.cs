using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zalan_Csecs_Lab6.Models;

namespace Zalan_Csecs_Lab6.Data
{
    public class Zalan_Csecs_Lab6Context : DbContext
    {
        public Zalan_Csecs_Lab6Context (DbContextOptions<Zalan_Csecs_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Zalan_Csecs_Lab6.Models.Book> Book { get; set; }
    }
}
