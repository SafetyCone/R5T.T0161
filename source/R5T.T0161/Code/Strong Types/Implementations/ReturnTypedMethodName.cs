using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IReturnTypedMethodName"/>
    [StrongTypeImplementationMarker]
    public class ReturnTypedMethodName : TypedBase<string>, IStrongTypeMarker,
        IReturnTypedMethodName
    {
        public ReturnTypedMethodName(string value)
            : base(value)
        {
        }
    }
}
