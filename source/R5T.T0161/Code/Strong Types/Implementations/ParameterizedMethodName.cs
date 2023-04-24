using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IParameterizedMethodName"/>
    [StrongTypeImplementationMarker]
    public class ParameterizedMethodName : TypedBase<string>, IStrongTypeMarker,
        IParameterizedMethodName
    {
        public ParameterizedMethodName(string value)
            : base(value)
        {
        }
    }
}
