using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value can be considered to contain a type name.
    /// Whether this type is <see cref="ITypeParameterizedTyped"/> or not is indeterminate.
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeNamed : IStrongTypeMarker,
        ITyped<string>
    {
    }
}