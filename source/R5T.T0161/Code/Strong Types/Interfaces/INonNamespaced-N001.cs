using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161.N001
{
    /// <summary>
    /// Strongly-types a string as not having a namespace.
    /// </summary>
    [StrongTypeMarker]
    public interface INonNamespaced : IStrongTypeMarker,
        ITyped<string>
    {
    }
}