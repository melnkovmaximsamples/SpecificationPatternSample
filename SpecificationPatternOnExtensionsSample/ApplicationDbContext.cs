using Microsoft.EntityFrameworkCore;
using SpecificationPatternOnExtensionsSample.Entities;

namespace SpecificationPatternOnExtensionsSample;

public class ApplicationDbContext: DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
}