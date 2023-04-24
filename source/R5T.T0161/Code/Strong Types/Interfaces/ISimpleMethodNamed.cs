using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Indicates the underlying value contains a simple method name.
    /// Note that even simple method names are <see cref="ITypeParameterized"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface ISimpleMethodNamed : IStrongTypeMarker,
        ISimplestMethodNamed,
        ITypeParameterized
    {
    }
}
