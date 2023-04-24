using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IFullMethodName"/>
    [StrongTypeImplementationMarker]
    public class FullMethodName : TypedBase<string>, IStrongTypeMarker,
        IFullMethodName
    {
        public FullMethodName(string value)
            : base(value)
        {
        }
    }
}
