using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ISimpleMethodName"/>
    [StrongTypeImplementationMarker]
    public class SimpleMethodName : TypedBase<string>, IStrongTypeMarker,
        ISimpleMethodName
    {
        public SimpleMethodName(string value)
            : base(value)
        {
        }
    }
}
