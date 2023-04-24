using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value is a simplest method name.
    /// Simplest method names are just the name of the method, and are <strong>not</strong> <see cref="ITypeParameterized"/> like <see cref="ISimpleMethodNamed"/>s.
    /// </summary>
    [StrongTypeMarker]
    public interface ISimplestMethodName : IStrongTypeMarker,
        ISimplestMethodNamed
    {
    }
}
