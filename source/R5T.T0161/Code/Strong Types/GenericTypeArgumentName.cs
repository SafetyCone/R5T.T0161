using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class GenericTypeArgumentName : TypedString, IStrongTypeMarker
    {
        public GenericTypeArgumentName(string value)
            : base(value)
        {
        }
    }
}
