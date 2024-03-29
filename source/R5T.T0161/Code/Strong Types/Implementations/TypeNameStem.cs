using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <inheritdoc cref="ITypeNameStem"/>
    [StrongTypeImplementationMarker]
    public class TypeNameStem : TypedBase<string>, IStrongTypeMarker,
        ITypeNameStem
    {
        public TypeNameStem(string value)
            : base(value)
        {
        }
    }
}
