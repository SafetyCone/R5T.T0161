using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IMemberName"/>
    [StrongTypeImplementationMarker]
    public class MemberName : TypedBase<string>, IStrongTypeMarker,
        IMemberName
    {
        public MemberName(string value)
            : base(value)
        {
        }
    }
}
