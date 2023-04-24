using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public interface INamespaceName : IStrongTypeMarker,
        IMemberName,
        // Yes, a namespace is itself namespace-named.
        INamespaceNamed
    {
    }
}
