using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value has-a full property name.
    /// See <see cref="Documentation.PropertyName"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IFullPropertyNamed : IStrongTypeMarker,
        INamespacedTypedPropertyNamed,
        IOutputTypeNamed
    {
    }
}
