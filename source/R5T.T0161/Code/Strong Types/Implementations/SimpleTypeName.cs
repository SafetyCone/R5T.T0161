using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ISimpleTypeName"/>
    [StrongTypeImplementationMarker]
    public class SimpleTypeName : TypedBase<string>, IStrongTypeMarker,
        ISimpleTypeName
    {
        public SimpleTypeName(string value)
            : base(value)
        {
        }
    }
}
