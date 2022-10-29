using System.Linq.Expressions;
using SpecificationPatternSample.Entities;

namespace SpecificationPatternSample.Specifications.ConcreteSpecifications;

public class MovieReleasedFiveYearsAgoOrEarlier: LinqSpecification<Movie>
{
    public override Expression<Func<Movie, bool>> AsExpression()
    {
        return movie => DateTime.Now.Year - movie.ReleaseDate.Year >= 5;
    }
}