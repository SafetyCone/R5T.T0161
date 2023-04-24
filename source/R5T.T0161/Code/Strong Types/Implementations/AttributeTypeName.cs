using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IAttributeTypeName"/>
    [StrongTypeImplementationMarker]
    public class AttributeTypeName : TypedBase<string>, IStrongTypeMarker,
        IAttributeTypeName
    {
        public AttributeTypeName(string value)
            : base(value)
        {
        }
    }
}
