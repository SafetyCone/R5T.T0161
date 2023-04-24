using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ITypeNamedMethodName"/>
    [StrongTypeImplementationMarker]
    public class TypeNamedMethodName : TypedBase<string>, IStrongTypeMarker,
        ITypeNamedMethodName
    {
        public TypeNamedMethodName(string value)
            : base(value)
        {
        }
    }
}
