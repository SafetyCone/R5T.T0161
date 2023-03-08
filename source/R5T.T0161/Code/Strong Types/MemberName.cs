using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// Types, methods, events, all are members.
    /// Use a member name when a name could be a type name, method name, or other name.
    /// This is for member names that are not "full" member names.
    /// For full member names use <see cref="FullMemberName"/>.
    /// </summary>
    [StrongTypeMarker]
    public class MemberName : TypedString, IStrongTypeMarker
    {
        public MemberName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The full name of a member.
    /// This is for member names that are "full" member names.
    /// For simple member names use <see cref="MemberName"/>.
    /// </summary>
    [StrongTypeMarker]
    public class FullMemberName : TypedString, IStrongTypeMarker
    {
        public FullMemberName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// A full member name, prefixed with the member kind marker (like "T:" for types, "M:" for methods).
    /// </summary>
    [StrongTypeMarker]
    public class KindMarkedFullMemberName : TypedString, IStrongTypeMarker
    {
        public KindMarkedFullMemberName(string value)
            : base(value)
        {
        }
    }
}
