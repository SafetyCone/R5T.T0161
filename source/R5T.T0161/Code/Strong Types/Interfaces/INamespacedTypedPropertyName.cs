using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value is-a namespaced, typed, property name.
    /// </summary>
    [StrongTypeMarker]
    public interface INamespacedTypedPropertyName : IStrongTypeMarker,
        INamespacedTypedPropertyNamed
    {
    }
}
