using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="INamespacedTypedPropertyName"/>
    [StrongTypeImplementationMarker]
    public class NamespacedTypedPropertyName : TypedBase<string>, IStrongTypeMarker,
        INamespacedTypedPropertyName
    {
        public NamespacedTypedPropertyName(string value)
            : base(value)
        {
        }
    }
}
