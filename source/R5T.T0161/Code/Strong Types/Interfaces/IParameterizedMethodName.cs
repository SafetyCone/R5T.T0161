using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a method, including its parameters, but not its type name.
    /// </summary>
    [StrongTypeMarker]
    public interface IParameterizedMethodName : IStrongTypeMarker,
        IMemberName
    {
    }
}
