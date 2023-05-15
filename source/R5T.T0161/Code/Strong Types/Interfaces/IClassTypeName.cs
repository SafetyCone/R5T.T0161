using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Strongly-types a string as the name of an class type.
    /// <para>
    /// <inheritdoc cref="Documentation.SimpleTypeName" path="/definition"/>
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IClassTypeName : IStrongTypeMarker,
        ISimpleTypeName
    {
    }
}
