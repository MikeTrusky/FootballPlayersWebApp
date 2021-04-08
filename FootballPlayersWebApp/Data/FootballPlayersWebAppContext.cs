using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FootballPlayersWebApp.Models;

namespace FootballPlayersWebApp.Data
{
    public class FootballPlayersWebAppContext : DbContext
    {
        public FootballPlayersWebAppContext (DbContextOptions<FootballPlayersWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<FootballPlayersWebApp.Models.Footballer> Footballer { get; set; }
    }
}
