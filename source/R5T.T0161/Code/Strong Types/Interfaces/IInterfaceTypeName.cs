using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Strongly-types a string as the name of an interface type.
    /// <para>
    /// <inheritdoc cref="Documentation.SimpleTypeName" path="/definition"/>
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IInterfaceTypeName : IStrongTypeMarker,
        ISimpleTypeName
    {
    }
}
