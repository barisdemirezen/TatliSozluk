using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatliSozluk.Domain.Models;

namespace TatliSozluk.Domain.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
            public DbSet<Post> Post { get; set; }
            public DbSet<Author> Author { get; set; }
    }
}
