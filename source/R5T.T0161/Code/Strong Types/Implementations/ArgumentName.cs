using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IArgumentName"/>
    [StrongTypeImplementationMarker]
    public class ArgumentName : TypedBase<string>, IStrongTypeMarker,
        IArgumentName
    {
        public ArgumentName(string value)
            : base(value)
        {
        }
    }
}
