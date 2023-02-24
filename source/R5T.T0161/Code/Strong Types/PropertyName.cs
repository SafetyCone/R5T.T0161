using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// The name of a property.
    /// (Just the simple property name, not including its type name.)
    /// </summary>
    [StrongTypeMarker]
    public class PropertyName : TypedString, IStrongTypeMarker
    {
        public PropertyName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The full name of a property, including it's type name, which includes the namespace of the type.
    /// </summary>
    [StrongTypeMarker]
    public class TypeNamedPropertyName : TypedString, IStrongTypeMarker
    {
        public TypeNamedPropertyName(string value)
            : base(value)
        {
        }
    }

    /// <summary>
    /// The name of a property, including it's simple type name, which does not include the namespace of the type.
    /// </summary>
    [StrongTypeMarker]
    public class SimpleTypeNamedPropertyName : TypedString, IStrongTypeMarker
    {
        public SimpleTypeNamedPropertyName(string value)
            : base(value)
        {
        }
    }
}
