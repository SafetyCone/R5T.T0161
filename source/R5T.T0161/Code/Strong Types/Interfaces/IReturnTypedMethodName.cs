using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The simple name of a method, with its return type.
    /// </summary>
    [StrongTypeMarker]
    public interface IReturnTypedMethodName : ITyped<string>, IStrongTypeMarker,
        IMemberName
    {
    }
}
