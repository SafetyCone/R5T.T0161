using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value contains a member of a namespaced type name.
    /// </summary>
    [StrongTypeMarker]
    public interface INamespacedTypeNamedMember : IStrongTypeMarker,
        INamespacedTypeNamed
    {
    }
}
