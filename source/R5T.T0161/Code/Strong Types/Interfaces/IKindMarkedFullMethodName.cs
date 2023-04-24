using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The full name of a method, but prefixed with the method kind marker "M:".
    /// </summary>
    [StrongTypeMarker]
    public interface IKindMarkedFullMethodName : IStrongTypeMarker,
        IKindMarkedFullMemberName,
        IMethodName
    {
    }
}
