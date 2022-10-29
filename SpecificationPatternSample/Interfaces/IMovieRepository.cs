using SpecificationPatternSample.Entities;

namespace SpecificationPatternSample.Interfaces;

public interface IMovieRepository
{
    IReadOnlyList<Movie> Find(ISpecification<Movie> specification);
}