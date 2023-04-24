using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value has-a namespaced, typed, property name.
    /// </summary>
    [StrongTypeMarker]
    public interface INamespacedTypedPropertyNamed : IStrongTypeMarker,
        INamespacedTypeNamedMember,
        ISimplePropertyNamed
    {
    }
}
