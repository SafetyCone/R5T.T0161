using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IKindMarkedTypeName"/>
    [StrongTypeImplementationMarker]
    public class KindMarkedTypeName : TypedBase<string>, IStrongTypeMarker,
        IKindMarkedTypeName
    {
        public KindMarkedTypeName(string value)
            : base(value)
        {
        }
    }
}
