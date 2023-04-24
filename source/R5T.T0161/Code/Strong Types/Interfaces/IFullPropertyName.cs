using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// The full name of a property, including the namespaced type name of its declaring type, and the namespaced type name of the property's type.
    /// </summary>
    [StrongTypeMarker]
    public interface IFullPropertyName : IStrongTypeMarker,
        IFullPropertyNamed
    {
    }
}
