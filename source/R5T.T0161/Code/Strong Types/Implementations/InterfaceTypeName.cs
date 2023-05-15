using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="IInterfaceTypeName"/>
    [StrongTypeImplementationMarker]
    public class InterfaceTypeName : TypedBase<string>, IStrongTypeMarker,
        IInterfaceTypeName
    {
        public InterfaceTypeName(string value)
            : base(value)
        {
        }
    }
}
