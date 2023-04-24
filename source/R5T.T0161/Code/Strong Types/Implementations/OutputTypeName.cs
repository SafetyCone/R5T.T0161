using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IOutputTypeName"/>
    [StrongTypeImplementationMarker]
    public class OutputTypeName : TypedBase<string>, IStrongTypeMarker,
        IOutputTypeName
    {
        public OutputTypeName(string value)
            : base(value)
        {
        }
    }
}
