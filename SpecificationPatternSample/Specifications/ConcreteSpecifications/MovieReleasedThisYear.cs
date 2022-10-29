using System.Linq.Expressions;
using SpecificationPatternSample.Entities;

namespace SpecificationPatternSample.Specifications.ConcreteSpecifications;

public class MovieReleasedThisYear: LinqSpecification<Movie>
{
    public override Expression<Func<Movie, bool>> AsExpression()
    {
        return movie => movie.ReleaseDate.Year == DateTime.Now.Year;
    }
}