using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161.N001
{
    /// <inheritdoc cref="INonTypeParametered"/>
    [StrongTypeImplementationMarker]
    public class NonTypeParametered : TypedBase<string>, IStrongTypeMarker,
        INonTypeParametered
    {
        public NonTypeParametered(string value)
            : base(value)
        {
        }
    }
}