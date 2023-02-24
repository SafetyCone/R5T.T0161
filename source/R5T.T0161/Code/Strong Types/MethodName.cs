using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a method.
    /// (Just the simple method name, not including its type name or parameters.)
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
    [StrongTypeMarker]
    public class FullMethodName : TypedString, IStrongTypeMarker
    {
        public FullMethodName(string value)
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
}
