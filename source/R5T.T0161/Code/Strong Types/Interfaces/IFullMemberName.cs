using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The full name of a member.
    /// This is for member names that are "full" member names.
    /// For simple member names use <see cref="MemberName"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IFullMemberName : IStrongTypeMarker,
        IMemberName
    {
    }
}
