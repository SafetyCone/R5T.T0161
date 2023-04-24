using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a method, including its type name, which includes its namespace, but not its parameters.
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeNamedMethodName : IStrongTypeMarker,
        IMemberName
    {
    }
}
