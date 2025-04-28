using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaProgreso1_Navarrete.Models;

    public class PruebaProgreso1_NavarreteContextSQLServer : DbContext
    {
        public PruebaProgreso1_NavarreteContextSQLServer (DbContextOptions<PruebaProgreso1_NavarreteContextSQLServer> options)
            : base(options)
        {
        }

        public DbSet<PruebaProgreso1_Navarrete.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<PruebaProgreso1_Navarrete.Models.Reserva> Reserva { get; set; } = default!;

public DbSet<PruebaProgreso1_Navarrete.Models.PlanRecompensa> PlanRecompensa { get; set; } = default!;
    }
