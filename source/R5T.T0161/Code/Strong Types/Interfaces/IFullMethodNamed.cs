using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates that the underlying value contains a full method name.
    /// Full method nameds are both <see cref="INamespacedTypedParameterizedMethodNamed"/> and <see cref="IOutputTypeNamed"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IFullMethodNamed : IStrongTypeMarker,
        INamespacedTypedParameterizedMethodNamed,
        IOutputTypeNamed
    {
    }
}
