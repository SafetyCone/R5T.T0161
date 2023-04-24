using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ITypeNamedReturnTypedMethodName"/>
    [StrongTypeImplementationMarker]
    public class TypeNamedReturnTypedMethodName : TypedBase<string>, IStrongTypeMarker,
        ITypeNamedReturnTypedMethodName
    {
        public TypeNamedReturnTypedMethodName(string value)
            : base(value)
        {
        }
    }
}
