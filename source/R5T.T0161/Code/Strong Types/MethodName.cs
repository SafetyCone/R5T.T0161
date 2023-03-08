using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a method.
    /// (Just the simple method name, not including its type name or parameters, but including its generic type arguments since the count of those are used to determine its uniqueness.)
    /// </summary>
    [StrongTypeMarker]
    public class MethodName : TypedString, IStrongTypeMarker
    {
        public MethodName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The full name of a method, including its type name, which includes its namespace, and parameters.
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
    public class FullMethodName : TypedString, IStrongTypeMarker
    {
        public FullMethodName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The full name of a method, but prefixed with the method kind marker "M:".
    /// </summary>
    [StrongTypeMarker]
    public class KindMarkedFullMethodName : TypedString, IStrongTypeMarker
    {
        public KindMarkedFullMethodName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The name of a method, including its type name, which includes its namespace, but not its parameters.
    /// </summary>
    [StrongTypeMarker]
    public class TypeNamedMethodName : TypedString, IStrongTypeMarker
    {
        public TypeNamedMethodName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The name of a method, including its parameters, but not its type name.
    /// </summary>
    [StrongTypeMarker]
    public class ParameterizedMethodName : TypedString, IStrongTypeMarker
    {
        public ParameterizedMethodName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The simple name of a method, with its return type.
    /// </summary>
    [StrongTypeMarker]
    public class ReturnTypedMethodName : TypedString, IStrongTypeMarker
    {
        public ReturnTypedMethodName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The name of a method, including its type name, which includes its namespace, but not its parameters, with its return type.
    /// </summary>
    [StrongTypeMarker]
    public class TypeNamedReturnTypedMethodName : TypedString, IStrongTypeMarker
    {
        public TypeNamedReturnTypedMethodName(string value)
            : base(value)
        {
        }
    }
}
