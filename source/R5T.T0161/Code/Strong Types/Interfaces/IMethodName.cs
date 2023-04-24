using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Chooses <see cref="ISimpleMethodName"/> as the default for method names.
    /// </summary>
    [StrongTypeMarker]
    public interface IMethodName : IStrongTypeMarker,
        ISimpleMethodName
    {
    }
}
