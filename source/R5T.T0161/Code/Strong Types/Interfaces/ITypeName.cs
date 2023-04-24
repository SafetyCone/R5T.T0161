using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Fully qualified type name.
    /// <inheritdoc cref="Documentation.TypeName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeName : IStrongTypeMarker,
        IMemberName
    {
    }
}


namespace R5T.T0161.N001
{
    /// <summary>
    /// Simple type name.
    /// <inheritdoc cref="Documentation.SimpleTypeName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeName : ITyped<string>, IStrongTypeMarker
    {
    }
}