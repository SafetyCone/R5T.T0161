using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Fully qualified type name, but prefixed with the type kind marker "T:".
    /// <inheritdoc cref="Documentation.TypeName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public interface IKindMarkedTypeName : IStrongTypeMarker,
        IKindMarked,
        IKindMarkedMemberName
    {
    }
}
