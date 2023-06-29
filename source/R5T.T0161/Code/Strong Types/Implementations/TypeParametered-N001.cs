using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161.N001
{
    /// <inheritdoc cref="ITypeParametered"/>
    [StrongTypeImplementationMarker]
    public class TypeParametered : TypedBase<string>, IStrongTypeMarker,
        ITypeParametered
    {
        public TypeParametered(string value)
            : base(value)
        {
        }
    }
}