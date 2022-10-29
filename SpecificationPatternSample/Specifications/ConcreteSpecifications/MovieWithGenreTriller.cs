using SpecificationPatternSample.Entities;

namespace SpecificationPatternSample.Specifications.ConcreteSpecifications;

public class MovieWithGenreTriller: CompositeSpecification<Movie>
{
    public override bool IsSatisfiedBy(Movie movie)
    {
        return movie.Genre == "Triller";
    }
}