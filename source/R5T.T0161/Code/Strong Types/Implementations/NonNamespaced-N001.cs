using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161.N001
{
    /// <inheritdoc cref="INonNamespaced"/>
    [StrongTypeImplementationMarker]
    public class NonNamespaced : TypedBase<string>, IStrongTypeMarker,
        INonNamespaced
    {
        public NonNamespaced(string value)
            : base(value)
        {
        }
    }
}