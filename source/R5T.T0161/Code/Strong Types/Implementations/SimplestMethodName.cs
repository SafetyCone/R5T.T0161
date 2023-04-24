using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ISimplestMethodName"/>
    [StrongTypeImplementationMarker]
    public class SimplestMethodName : TypedBase<string>, IStrongTypeMarker,
        ISimplestMethodName
    {
        public SimplestMethodName(string value)
            : base(value)
        {
        }
    }
}
