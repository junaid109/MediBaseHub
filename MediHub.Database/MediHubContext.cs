    using MediHub.Shared.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    namespace MediHub.Database
    {
        public class MediHubContext : DbContext
        {
            public DbSet<Patient> Patients => Set<Patient>();
            public DbSet<Appointment> Appointments => Set<Appointment>();

            public MediHubContext(DbContextOptions<MediHubContext> options) : base(options) { }
        }
    }