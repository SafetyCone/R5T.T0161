using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0161
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class ArgumentName : TypedString, IStrongTypeMarker
    {
        public ArgumentName(string value)
            : base(value)
        {
        }
    }
}
