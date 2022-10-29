using Microsoft.EntityFrameworkCore;
using SpecificationPatternSample.Entities;
using SpecificationPatternSample.Enums;

namespace SpecificationPatternSample;

public class ApplicationDbContext: DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
}