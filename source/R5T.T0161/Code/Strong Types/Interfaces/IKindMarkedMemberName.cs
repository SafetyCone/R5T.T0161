using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// A member name, prefixed with the member kind marker (like "T:" for types, "M:" for methods).
    /// </summary>
    [StrongTypeMarker]
    public interface IKindMarkedMemberName : IStrongTypeMarker,
        IKindMarked,
        IMemberNamed
    {
    }
}
