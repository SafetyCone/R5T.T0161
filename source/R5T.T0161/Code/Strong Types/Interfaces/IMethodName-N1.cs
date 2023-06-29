using System;

using R5T.T0178;

using R5T.T0161.N001;


namespace R5T.T0161.N1
{
    /// <summary>
    /// Method name (best).
    /// <para>
    /// Non-namespaced, non-type parametered, non-parameter listed.
    /// </para>
    /// <para>Example: ToString, or ContainsKey</para>
    /// </summary>
    [StrongTypeMarker]
    public interface IMethodName : IStrongTypeMarker,
        IMemberName,
        INonNamespaced,
        INonTypeParametered,
        INonParameterListed
    {
    }
}
