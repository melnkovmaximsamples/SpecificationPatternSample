using SpecificationPatternSample.Entities;
using SpecificationPatternSample.Enums;
using SpecificationPatternSample.Interfaces;

namespace SpecificationPatternSample.Repositories;

public class MovieRepository: IMovieRepository
{
    private readonly ApplicationDbContext _db;

    public MovieRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public IReadOnlyList<Movie> Find(ISpecification<Movie> specification)
    {
        return _db.Movies.Where(specification.IsSatisfiedBy).ToList();
    }
}