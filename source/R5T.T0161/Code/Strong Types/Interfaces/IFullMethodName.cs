using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0161
{
    /// <summary>
    /// The full name of a property, including its namespaced type name and type.
    /// </summary>
    /// <remarks>
    /// A full method name looks like:
    /// <para>
    /// Namespace01.TypeName01.MethodName01(System.String stringA, System.Int integerB);System.Void
    /// </para>
    /// Which is similar to method parameter named identity name, but without the leading "M:":
    /// <para>
    /// M:Namespace01.TypeName01.MethodName01(System.String stringA, System.Int integerB);System.Void
    /// </para>
    /// Which is similar to named identity name, but without the trailing output type:
    /// <para>
    /// M:Namespace01.TypeName01.MethodName01(System.String stringA, System.Int integerB)
    /// </para>
    /// And contains the simple method name (or just method name):
    /// <para>
    /// MethodName01
    /// </para>
    /// </remarks>
    [StrongTypeMarker]
    public interface IFullMethodName : IStrongTypeMarker,
        // Yes.
        IFullMethodNamed,
        IMemberName
    {
    }
}
