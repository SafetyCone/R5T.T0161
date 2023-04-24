using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Fully qualified property name, but prefixed with the type kind marker "P:".
    /// <inheritdoc cref="Documentation.PropertyName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public interface IKindMarkedFullPropertyName : IStrongTypeMarker,
        IKindMarked,
        IKindMarkedMemberName
    {
    }
}
