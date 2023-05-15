using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IClassTypeName"/>
    [StrongTypeImplementationMarker]
    public class ClassTypeName : TypedBase<string>, IStrongTypeMarker,
        IClassTypeName
    {
        public ClassTypeName(string value)
            : base(value)
        {
        }
    }
}
