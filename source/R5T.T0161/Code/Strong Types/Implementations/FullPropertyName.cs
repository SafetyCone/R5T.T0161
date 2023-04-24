using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IFullPropertyName"/>
    [StrongTypeImplementationMarker]
    public class FullPropertyName : TypedBase<string>, IStrongTypeMarker,
        IFullPropertyName
    {
        public FullPropertyName(string value)
            : base(value)
        {
        }
    }
}
