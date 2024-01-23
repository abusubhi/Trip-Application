using Microsoft.EntityFrameworkCore;
using StepTrips.DataContract.Model;
using System;

namespace StepTrips.DataAccess;

public class ApplicationDbContext : DbContext
{



    public ApplicationDbContext()
    {

    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


    }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Plane> Planes { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<TripReservation> TripReservations { get; set; }
    public DbSet<TripStatus> TripStatuses { get; set; }
    public DbSet<TripType> TripTypes { get; set; }
    public DbSet<ClientReservation> ClientReservations { get; set; }

}
