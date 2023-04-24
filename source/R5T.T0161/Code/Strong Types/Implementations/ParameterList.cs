using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IParameterList"/>
    [StrongTypeImplementationMarker]
    public class ParameterList : TypedBase<string>, IStrongTypeMarker,
        IParameterList
    {
        public ParameterList(string value)
            : base(value)
        {
        }
    }
}
