using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates a member name is prefixed with the member kind marker (like "T:" for types, "M:" for methods).
    /// </summary>
    [StrongTypeMarker]
    public interface IKindMarked : ITyped<string>, IStrongTypeMarker
    {
    }
}
