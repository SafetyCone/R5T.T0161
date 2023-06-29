using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161.N001
{
    /// <inheritdoc cref="INonParameterListed"/>
    [StrongTypeImplementationMarker]
    public class NonParameterListed : TypedBase<string>, IStrongTypeMarker,
        INonParameterListed
    {
        public NonParameterListed(string value)
            : base(value)
        {
        }
    }
}