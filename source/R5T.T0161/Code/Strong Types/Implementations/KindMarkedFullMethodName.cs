using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IKindMarkedFullMethodName"/>
    [StrongTypeImplementationMarker]
    public class KindMarkedFullMethodName : TypedBase<string>, IStrongTypeMarker,
        IKindMarkedFullMethodName
    {
        public KindMarkedFullMethodName(string value)
            : base(value)
        {
        }
    }
}
