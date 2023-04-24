using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ITypeNamedPropertyName"/>
    [StrongTypeImplementationMarker]
    public class TypeNamedPropertyName : TypedBase<string>, IStrongTypeMarker,
        ITypeNamedPropertyName
    {
        public TypeNamedPropertyName(string value)
            : base(value)
        {
        }
    }
}
