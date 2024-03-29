using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// Simple type name.
    /// <inheritdoc cref="Documentation.SimpleTypeName" path="/definition"/>
    /// <para>Example: String, or Dictionary&lt;TKey, TValue&gt;</para>
    /// </summary>
    [StrongTypeMarker]
    public interface ISimpleTypeName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}