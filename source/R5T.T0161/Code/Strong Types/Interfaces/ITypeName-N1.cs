using System;

using R5T.T0178;

using R5T.T0161.N001;


namespace R5T.T0161.N1
{
    /// <summary>
    /// Type name (best).
    /// <para>Non-namespaced, non-type parametered.</para>
    /// <para>Examples: String, Dictionary (without the type parameters)</para>
    /// </summary>
    [StrongTypeMarker]
    public interface ITypeName : IStrongTypeMarker,
        IMemberName,
        INonNamespaced,
        INonTypeParametered
    {
    }
}
