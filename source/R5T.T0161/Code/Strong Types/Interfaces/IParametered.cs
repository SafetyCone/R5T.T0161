using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value contains a parameter.
    /// </summary>
    [StrongTypeMarker]
    public interface IParametered : IStrongTypeMarker,
        ITypeNamed,
        IVariableNamed
    {
    }
}