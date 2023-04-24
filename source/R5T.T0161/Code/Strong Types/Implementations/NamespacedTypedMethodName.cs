using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="INamespacedTypedMethodName"/>
    [StrongTypeImplementationMarker]
    public class NamespacedTypedMethodName : TypedBase<string>, IStrongTypeMarker,
        INamespacedTypedMethodName
    {
        public NamespacedTypedMethodName(string value)
            : base(value)
        {
        }
    }
}
