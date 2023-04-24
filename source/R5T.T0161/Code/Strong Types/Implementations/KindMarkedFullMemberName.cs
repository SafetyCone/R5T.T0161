using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IKindMarkedFullMemberName"/>
    [StrongTypeImplementationMarker]
    public class KindMarkedFullMemberName : TypedBase<string>, IStrongTypeMarker,
        IKindMarkedFullMemberName
    {
        public KindMarkedFullMemberName(string value)
            : base(value)
        {
        }
    }
}
