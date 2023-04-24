using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a property, including it's simple type name, which does not include the namespace of the type.
    /// </summary>
    [StrongTypeMarker]
    public interface ISimpleTypeNamedPropertyName : ITyped<string>, IStrongTypeMarker
    {
    }
}
