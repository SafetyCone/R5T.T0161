using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value is-a namespaced type name.
    /// </summary>
    [StrongTypeMarker]
    public interface INamespacedTypeName : IStrongTypeMarker,
        INamespacedTypeNamed
    {
    }
}
