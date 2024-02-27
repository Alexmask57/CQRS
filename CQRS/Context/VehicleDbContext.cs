using CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Context;

public class VehicleDbContext(DbContextOptions<VehicleDbContext> options) : DbContext(options)
{
    public DbSet<Vehicle>? Vehicles { get; set; }
}