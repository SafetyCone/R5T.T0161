using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value can be considered to have an output type name.
    /// (Like methods, or properties and fields.)
    /// Output types are only <see cref="ITypeNamed"/>, which may or may not be <see cref="ITypeParameterizedTyped"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IOutputTypeName : IStrongTypeMarker,
        // Yes, output types are output typed.
        IOutputTypeNamed
    {
    }
}