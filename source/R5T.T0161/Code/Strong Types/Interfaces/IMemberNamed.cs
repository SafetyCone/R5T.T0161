using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value has a member name.
    /// All types, methods, events, really just everything, are members. (I.e. members of something.)
    /// Use a member name when a name could be a type name, method name, or other name.
    /// Member names could be "full" member names (<see cref="IFullMemberName"/>)
    /// </summary>
    [StrongTypeMarker]
    public interface IMemberNamed : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
