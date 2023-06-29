using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161.N001
{
    /// <inheritdoc cref="INamespaced"/>
    [StrongTypeImplementationMarker]
    public class Namespaced : TypedBase<string>, IStrongTypeMarker,
        INamespaced
    {
        public Namespaced(string value)
            : base(value)
        {
        }
    }
}