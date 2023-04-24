using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IGenericTypeArgumentName"/>
    [StrongTypeImplementationMarker]
    public class GenericTypeArgumentName : TypedBase<string>, IStrongTypeMarker,
        IGenericTypeArgumentName
    {
        public GenericTypeArgumentName(string value)
            : base(value)
        {
        }
    }
}
