using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value is a parameter.
    /// </summary>
    [StrongTypeMarker]
    public interface IParameter : IStrongTypeMarker,
        IParametered
    {
    }
}