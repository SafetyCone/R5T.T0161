using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161.N001
{
    /// <summary>
    /// Indicates the underlying value contains zero or more parameters in a parameter list.
    /// </summary>
    [StrongTypeMarker]
    public interface IParameterListed : IStrongTypeMarker,
        ITyped<string>
    {
    }
}