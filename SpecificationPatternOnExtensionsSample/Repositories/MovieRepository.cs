using System.Linq.Expressions;
using SpecificationPatternOnExtensionsSample.Entities;
using SpecificationPatternOnExtensionsSample.Interfaces;

namespace SpecificationPatternOnExtensionsSample.Repositories;

public class MovieRepository: IMovieRepository
{
    private readonly ApplicationDbContext _db;

    public MovieRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public IReadOnlyList<Movie> Find(Expression<Func<IQueryable<Movie>, IQueryable<Movie>>> specification)
    {
        return specification.Compile().Invoke(_db.Movies).ToList();
    }
}