using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IParameter"/>
    [StrongTypeImplementationMarker]
    public class Parameter : TypedBase<string>, IStrongTypeMarker,
        IParameter
    {
        public Parameter(string value)
            : base(value)
        {
        }
    }
}
