using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IFullMemberName"/>
    [StrongTypeImplementationMarker]
    public class FullMemberName : TypedBase<string>, IStrongTypeMarker,
        IFullMemberName
    {
        public FullMemberName(string value)
            : base(value)
        {
        }
    }
}
