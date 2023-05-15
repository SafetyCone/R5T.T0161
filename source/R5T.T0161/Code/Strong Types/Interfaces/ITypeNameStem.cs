using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Strongly-types a string as a type name stem.
    /// <para>
    /// <inheritdoc cref="Documentation.TypeNameStem" path="/definition"/>
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeNameStem : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
