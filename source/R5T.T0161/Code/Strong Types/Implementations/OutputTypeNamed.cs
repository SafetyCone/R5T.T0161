using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IOutputTypeNamed"/>
    [StrongTypeImplementationMarker]
    public class OutputTypeNamed : TypedBase<string>, IStrongTypeMarker,
        IOutputTypeNamed
    {
        public OutputTypeNamed(string value)
            : base(value)
        {
        }
    }
}
