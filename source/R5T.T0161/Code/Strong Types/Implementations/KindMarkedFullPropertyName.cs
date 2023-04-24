using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IKindMarkedFullPropertyName"/>
    [StrongTypeImplementationMarker]
    public class KindMarkedFullPropertyName : TypedBase<string>, IStrongTypeMarker,
        IKindMarkedFullPropertyName
    {
        public KindMarkedFullPropertyName(string value)
            : base(value)
        {
        }
    }
}
