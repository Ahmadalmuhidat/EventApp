using Microsoft.EntityFrameworkCore;
using EventApp;

namespace EventApp;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }


    public DbSet<EventModel> Events { get; set; }
}