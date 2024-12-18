﻿using Lab4RPBDIS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Route = Lab4RPBDIS.Models.Route;

namespace Lab4RPBDIS.Data
{
    public class TransportDbContext(DbContextOptions<TransportDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public virtual DbSet<Personnel> Personnels { get; set; }

        public virtual DbSet<Route> Routes { get; set; }

        public virtual DbSet<Schedule> Schedules { get; set; }

        public virtual DbSet<Stop> Stops { get; set; }
    }
}
