using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The full name of a property, including it's type name, which includes the namespace of the type.
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeNamedPropertyName : IStrongTypeMarker,
        IMemberName
    {
    }
}
