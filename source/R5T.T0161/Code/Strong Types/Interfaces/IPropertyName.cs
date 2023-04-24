using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a property.
    /// (Just the simple property name, not including its type name.)
    /// </summary>
    [StrongTypeMarker]
    public interface IPropertyName : IStrongTypeMarker,
        IMemberName
    {
    }
}
