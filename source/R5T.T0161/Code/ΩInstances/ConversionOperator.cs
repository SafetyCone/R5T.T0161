using System;


namespace R5T.T0161
{
    public class ConversionOperator : IConversionOperator
    {
        #region Infrastructure

        public static IConversionOperator Instance { get; } = new ConversionOperator();


        private ConversionOperator()
        {
        }

        #endregion
    }
}
