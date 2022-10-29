using System.Linq.Expressions;

namespace SpecificationPatternSample.Specifications;

public abstract class LinqSpecification<T>: CompositeSpecification<T>
{
    public abstract Expression<Func<T, bool>> AsExpression();
    public override bool IsSatisfiedBy(T candidate) => AsExpression().Compile()(candidate);
}