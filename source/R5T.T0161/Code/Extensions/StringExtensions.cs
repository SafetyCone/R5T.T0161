using System;
using System.Collections.Generic;

using R5T.T0161.N001;


namespace R5T.T0161.Extensions
{
    public static class StringExtensions
    {
        #region X'ed

        public static IArgumentName ToArgumentName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToArgumentName(value);
            return output;
        }

        public static IAttributeTypeName ToAttributeTypeName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToAttributeTypeName(value);
            return output;
        }

        public static IClassTypeName ToClassTypeName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToClassTypeName(value);
            return output;
        }

        public static IFullMethodName ToFullMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToFullMethodName(value);
            return output;
        }

        public static IFullPropertyName ToFullPropertyName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToFullPropertyName(value);
            return output;
        }

        public static IGenericTypeArgumentName ToGenericTypeArgumentName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToGenericTypeArgumentName(value);
            return output;
        }

        public static IInterfaceTypeName ToInterfaceTypeName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToInterfaceTypeName(value);
            return output;
        }

        public static IKindMarkedFullPropertyName ToKindMarkedFullPropertyName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToKindMarkedFullPropertyName(value);
            return output;
        }

        public static IKindMarkedFullMemberName ToKindMarkedFullMemberName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToKindMarkedFullMemberName(value);
            return output;
        }

        public static IKindMarkedFullMethodName ToKindMarkedFullMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToKindMarkedFullMethodName(value);
            return output;
        }

        public static IMethodName ToMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToMethodName(value);
            return output;
        }

        public static N1.IMethodName ToMethodName_N1(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToMethodName_N1(value);
            return output;
        }

        /// <inheritdoc cref="IStringOperator.ToNamespaced(string)"/>
        public static INamespaced ToNamespaced(this string value)
        {
            return Instances.StringOperator_Extensions.ToNamespaced(value);
        }

        public static INamespaceName ToNamespaceName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToNamespaceName(value);
            return output;
        }

        public static INamespacedTypedParameterizedMethodName ToNamespacedTypedParameterizedMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToNamespacedTypedParameterizedMethodName(value);
            return output;
        }

        public static INamespacedTypeName ToNamespacedTypeName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToNamespacedTypeName(value);
            return output;
        }

        public static INamespacedTypedMethodName ToNamespacedTypedMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToNamespacedTypedMethodName(value);
            return output;
        }

        public static INamespacedTypedPropertyName ToNamespacedTypedPropertyName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToNamespacedTypedPropertyName(value);
            return output;
        }

        public static IOutputTypeName ToOutputTypeName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToOutputTypeName(value);
            return output;
        }

        public static IOutputTypeNamed ToOutputTypeNamed(this string value)
        {
            var output = T0161.StringOperator.Instance.ToOutputTypeNamed(value);
            return output;
        }

        public static IParameterList ToParameterList(this string value)
        {
            var output = T0161.StringOperator.Instance.ToParameterList(value);
            return output;
        }

        public static IParameter ToParameter(this string value)
        {
            var output = T0161.StringOperator.Instance.ToParameter(value);
            return output;
        }

        public static ISimplestMethodName ToSimplestMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToSimplestMethodName(value);
            return output;
        }

        public static ISimpleMethodName ToSimpleMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToSimpleMethodName(value);
            return output;
        }

        public static ISimplePropertyName ToSimplePropertyName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToSimplePropertyName(value);
            return output;
        }

        /// <inheritdoc cref="T0161.IStringOperator.ToSimpleTypeName(string)"/>
        public static ISimpleTypeName ToSimpleTypeName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToSimpleTypeName(value);
            return output;
        }

        public static ITypeName ToTypeName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToTypeName(value);
            return output;
        }

        public static N1.ITypeName ToTypeName_N1(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToTypeName_N1(value);
            return output;
        }

        public static ITypeNameStem ToTypeNameStem(this string value)
        {
            var output = T0161.StringOperator.Instance.ToTypeNameStem(value);
            return output;
        }

        public static IEnumerable<ITypeNameStem> ToTypeNameStems(this IEnumerable<string> values)
        {
            var output = T0161.StringOperator.Instance.ToTypeNameStems(values);
            return output;
        }

        public static ITypeNamedMethodName ToTypeNamedMethodName(this string value)
        {
            var output = T0161.StringOperator.Instance.ToTypeNamedMethodName(value);
            return output;
        }

        /// <inheritdoc cref="IStringOperator.ToTypeParametered(string)"/>
        public static ITypeParametered ToTypeParametered(this string value)
        {
            return Instances.StringOperator_Extensions.ToTypeParametered(value);
        }

        #endregion


        #region Non-X'ed

        /// <inheritdoc cref="IStringOperator.ToNonParameterListed(string)"/>
        public static INonParameterListed ToNonParameterListed(this string value)
        {
            return Instances.StringOperator_Extensions.ToNonParameterListed(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNonNamespaced(string)"/>
        public static INonNamespaced ToNonNamespaced(this string value)
        {
            return Instances.StringOperator_Extensions.ToNonNamespaced(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNonTypeParametered(string)"/>
        public static INonTypeParametered ToNonTypeParametered(this string value)
        {
            return Instances.StringOperator_Extensions.ToNonTypeParametered(value);
        }

        #endregion
    }
}
