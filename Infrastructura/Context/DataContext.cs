using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Context;

public class DataContext : DbContext
{
    public DataContext (DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Challange> Challanges { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Participant> Participants { get; set; }
}
