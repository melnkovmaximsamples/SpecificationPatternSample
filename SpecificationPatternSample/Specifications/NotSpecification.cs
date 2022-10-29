using SpecificationPatternSample.Interfaces;

namespace SpecificationPatternSample.Specifications;

public class NotSpecification<T> : CompositeSpecification<T>
{
    readonly ISpecification<T> _other;
    public NotSpecification(ISpecification<T> other) => _other = other;
    public override bool IsSatisfiedBy(T candidate) => !_other.IsSatisfiedBy(candidate);
}