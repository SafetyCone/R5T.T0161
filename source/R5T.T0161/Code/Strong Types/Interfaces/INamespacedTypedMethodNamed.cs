using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value has-a namespaced, typed, method name.
    /// </summary>
    [StrongTypeMarker]
    public interface INamespacedTypedMethodNamed : IStrongTypeMarker,
        INamespacedTypeNamedMember,
        ISimpleMethodNamed
    {
    }
}
