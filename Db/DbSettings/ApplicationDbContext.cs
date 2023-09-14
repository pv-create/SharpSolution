using System.Collections.Specialized;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Db.DbSettings;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Compliment> Compliments { get; set; }
}