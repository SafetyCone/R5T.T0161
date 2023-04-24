using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ISimpleTypeNamedPropertyName"/>
    [StrongTypeImplementationMarker]
    public class SimpleTypeNamedPropertyName : TypedBase<string>, IStrongTypeMarker,
        ISimpleTypeNamedPropertyName
    {
        public SimpleTypeNamedPropertyName(string value)
            : base(value)
        {
        }
    }
}
