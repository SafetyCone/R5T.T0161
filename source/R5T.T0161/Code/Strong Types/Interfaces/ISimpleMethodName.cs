using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a method.
    /// (Just the simple method name, not including its type name or parameters, but including its generic type arguments since the count of those are used to determine its uniqueness.)
    /// </summary>
    [StrongTypeMarker]
    public interface ISimpleMethodName : IStrongTypeMarker,
        // Yes, a simple method name is simple method named.
        ISimpleMethodNamed,
        IMemberName,
        IMethodNamed
    {
    }
}
