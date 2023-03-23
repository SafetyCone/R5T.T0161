using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// The type name of an attribute.
    /// </summary>
    [StrongTypeMarker]
    public class AttributeTypeName : TypedString, IStrongTypeMarker
    {
        public AttributeTypeName(string value)
            : base(value)
        {
        }
    }
}
