using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates that the wrapped value contains a method name.
    /// Whether that method name is a <see cref="ISimpleMethodName"/> or <see cref="IFullMethodName"/>, that is not determined.
    /// </summary>
    [StrongTypeMarker]
    public interface IMethodNamed : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
