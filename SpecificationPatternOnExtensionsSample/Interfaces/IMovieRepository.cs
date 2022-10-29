using System.Linq.Expressions;
using SpecificationPatternOnExtensionsSample.Entities;

namespace SpecificationPatternOnExtensionsSample.Interfaces;

public interface IMovieRepository
{
    IReadOnlyList<Movie> Find(Expression<Func<IQueryable<Movie>, IQueryable<Movie>>> specification);
}