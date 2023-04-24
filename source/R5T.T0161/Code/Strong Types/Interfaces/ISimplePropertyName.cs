using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Simple property name.
    /// <inheritdoc cref="Documentation.SimplePropertyName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public interface ISimplePropertyName : IStrongTypeMarker,
        ISimplePropertyNamed
    {
    }
}