using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value contains a variable name.
    /// </summary>
    [StrongTypeMarker]
    public interface IVariableNamed : IStrongTypeMarker,
        ITyped<string>
    {
    }
}