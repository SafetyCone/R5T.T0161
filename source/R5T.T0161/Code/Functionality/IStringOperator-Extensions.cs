using System;

using R5T.T0132;
using R5T.T0161.N1;


namespace R5T.T0161.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        #region X'ed

        /// <inheritdoc cref="N1.IMethodName"/>
        public N1.IMethodName ToMethodName_N1(string value)
        {
            var output = new N1.MethodName(value);
            return output;
        }

        /// <inheritdoc cref="N001.INamespaced"/>
        public N001.INamespaced ToNamespaced(string value)
        {
            var output = new N001.Namespaced(value);
            return output;
        }

        /// <inheritdoc cref="N1.ITypeName"/>
        public N1.ITypeName ToTypeName_N1(string value)
        {
            var output = new N1.TypeName(value);
            return output;
        }

        /// <inheritdoc cref="N001.ITypeParametered"/>
        public N001.ITypeParametered ToTypeParametered(string value)
        {
            var output = new N001.TypeParametered(value);
            return output;
        }

        #endregion

        #region Non-X'ed

        /// <inheritdoc cref="N001.INonNamespaced"/>
        public N001.INonNamespaced ToNonNamespaced(string value)
        {
            var output = new N001.NonNamespaced(value);
            return output;
        }

        /// <inheritdoc cref="N001.INonParameterListed"/>
        public N001.INonParameterListed ToNonParameterListed(string value)
        {
            var output = new N001.NonParameterListed(value);
            return output;
        }

        /// <inheritdoc cref="N001.INonTypeParametered"/>
        public N001.INonTypeParametered ToNonTypeParametered(string value)
        {
            var output = new N001.NonTypeParametered(value);
            return output;
        }

        #endregion
    }
}
