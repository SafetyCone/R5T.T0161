using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="INamespacedTypedParameterizedMethodName"/>
    [StrongTypeImplementationMarker]
    public class NamespacedTypedParameterizedMethodName : TypedBase<string>, IStrongTypeMarker,
        INamespacedTypedParameterizedMethodName
    {
        public NamespacedTypedParameterizedMethodName(string value)
            : base(value)
        {
        }
    }
}
