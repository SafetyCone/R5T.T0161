using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ISimplePropertyName"/>
    [StrongTypeImplementationMarker]
    public class SimplePropertyName : TypedBase<string>, IStrongTypeMarker,
        ISimplePropertyName
    {
        public SimplePropertyName(string value)
            : base(value)
        {
        }
    }
}
