#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apsdotnet.Models;

    public class ApiDbContext : DbContext
    {
        public ApiDbContext (DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<apsdotnet.Models.Usuario> Usuario { get; set; }

        public DbSet<apsdotnet.Models.Aluno> Aluno { get; set; }

        public DbSet<apsdotnet.Models.Pessoa> Pessoa { get; set; }
    }
