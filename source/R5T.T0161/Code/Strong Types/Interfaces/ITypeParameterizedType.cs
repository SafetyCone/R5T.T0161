using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value is a type-parameterized type.
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeParameterizedType : IStrongTypeMarker,
        // Yes, a type-parameterized type is type-parameterized typed.
        ITypeParameterizedTyped
    {
    }
}