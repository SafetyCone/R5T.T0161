using System;

using R5T.T0178;


namespace R5T.T0161
{
    /// <summary>
    /// Chooses <see cref="ISimpleMethodName"/> as the default for method names.
    /// <para>
    /// <inheritdoc cref="ISimpleMethodName" path="/summary"/>
    /// </para>
    /// <para>Example: ToString, or ContainsKey&lt;TKey&gt;</para>
    /// </summary>
    [StrongTypeMarker]
    public interface IMethodName : IStrongTypeMarker,
        ISimpleMethodName
    {
    }
}
