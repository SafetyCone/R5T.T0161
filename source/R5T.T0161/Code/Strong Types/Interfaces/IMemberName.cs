using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Types, methods, events, all are members.
    /// Use a member name when a name could be a type name, method name, or other name.
    /// Member names could be "full" member names (<see cref="IFullMemberName"/>)
    /// </summary>
    [StrongTypeMarker]
    public interface IMemberName : IStrongTypeMarker,
        IMemberNamed
    {
    }
}
