using System;

using R5T.T0131;


namespace R5T.T0161.Z001
{
    [ValuesMarker]
    public partial interface ITokenSeparators : IValuesMarker
    {
        /// <summary>
        /// The semi-colon (';').
        /// </summary>
        public string MethodReturnTypeTokenSeparator => ";";

        /// <inheritdoc cref="MethodReturnTypeTokenSeparator"/>
        public char MethodReturnTypeTokenSeparator_Character => ';';
    }
}
