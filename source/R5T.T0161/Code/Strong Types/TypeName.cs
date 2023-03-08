using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// Fully qualified type name.
    /// <inheritdoc cref="Documentation.TypeName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public class TypeName : TypedString, IStrongTypeMarker
    {
        public TypeName(string value)
            : base(value)
        {
        }
    }


    /// <summary>
    /// Simple type name.
    /// <inheritdoc cref="Documentation.SimpleTypeName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public class SimpleTypeName : TypedString, IStrongTypeMarker
    {
        public SimpleTypeName(string value)
            : base(value)
        {
        }
    }


    /// <summary>
    /// Fully qualified type name, but prefixed with the type kind marker "T:".
    /// <inheritdoc cref="Documentation.TypeName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public class KindMarkedTypeName : TypedString, IStrongTypeMarker
    {
        public KindMarkedTypeName(string value)
            : base(value)
        {
        }
    }
}


namespace R5T.T0161.N001
{
    /// <summary>
    /// Simple type name.
    /// <inheritdoc cref="Documentation.SimpleTypeName" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public class TypeName : TypedString, IStrongTypeMarker
    {
        public TypeName(string value)
            : base(value)
        {
        }
    }
}