using System;
using System.Collections.Generic;


namespace R5T.T0161.Extensions
{
    public static class StringExtensions
    {
        public static IArgumentName ToArgumentName(this string value)
        {
            var output = StringOperator.Instance.ToArgumentName(value);
            return output;
        }

        public static IAttributeTypeName ToAttributeTypeName(this string value)
        {
            var output = StringOperator.Instance.ToAttributeTypeName(value);
            return output;
        }

        public static IClassTypeName ToClassTypeName(this string value)
        {
            var output = StringOperator.Instance.ToClassTypeName(value);
            return output;
        }

        public static IFullMethodName ToFullMethodName(this string value)
        {
            var output = StringOperator.Instance.ToFullMethodName(value);
            return output;
        }

        public static IFullPropertyName ToFullPropertyName(this string value)
        {
            var output = StringOperator.Instance.ToFullPropertyName(value);
            return output;
        }

        public static IGenericTypeArgumentName ToGenericTypeArgumentName(this string value)
        {
            var output = StringOperator.Instance.ToGenericTypeArgumentName(value);
            return output;
        }

        public static IInterfaceTypeName ToInterfaceTypeName(this string value)
        {
            var output = StringOperator.Instance.ToInterfaceTypeName(value);
            return output;
        }

        public static IKindMarkedFullPropertyName ToKindMarkedFullPropertyName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullPropertyName(value);
            return output;
        }

        public static IKindMarkedFullMemberName ToKindMarkedFullMemberName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullMemberName(value);
            return output;
        }

        public static IKindMarkedFullMethodName ToKindMarkedFullMethodName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullMethodName(value);
            return output;
        }

        public static IMethodName ToMethodName(this string value)
        {
            var output = StringOperator.Instance.ToMethodName(value);
            return output;
        }

        public static INamespaceName ToNamespaceName(this string value)
        {
            var output = StringOperator.Instance.ToNamespaceName(value);
            return output;
        }

        public static INamespacedTypedParameterizedMethodName ToNamespacedTypedParameterizedMethodName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypedParameterizedMethodName(value);
            return output;
        }

        public static INamespacedTypeName ToNamespacedTypeName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypeName(value);
            return output;
        }

        public static INamespacedTypedMethodName ToNamespacedTypedMethodName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypedMethodName(value);
            return output;
        }

        public static INamespacedTypedPropertyName ToNamespacedTypedPropertyName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypedPropertyName(value);
            return output;
        }

        public static IOutputTypeName ToOutputTypeName(this string value)
        {
            var output = StringOperator.Instance.ToOutputTypeName(value);
            return output;
        }

        public static IOutputTypeNamed ToOutputTypeNamed(this string value)
        {
            var output = StringOperator.Instance.ToOutputTypeNamed(value);
            return output;
        }

        public static IParameterList ToParameterList(this string value)
        {
            var output = StringOperator.Instance.ToParameterList(value);
            return output;
        }

        public static IParameter ToParameter(this string value)
        {
            var output = StringOperator.Instance.ToParameter(value);
            return output;
        }

        public static ISimplestMethodName ToSimplestMethodName(this string value)
        {
            var output = StringOperator.Instance.ToSimplestMethodName(value);
            return output;
        }

        public static ISimpleMethodName ToSimpleMethodName(this string value)
        {
            var output = StringOperator.Instance.ToSimpleMethodName(value);
            return output;
        }

        public static ISimplePropertyName ToSimplePropertyName(this string value)
        {
            var output = StringOperator.Instance.ToSimplePropertyName(value);
            return output;
        }

        /// <inheritdoc cref="IStringOperator.ToSimpleTypeName(string)"/>
        public static ISimpleTypeName ToSimpleTypeName(this string value)
        {
            var output = StringOperator.Instance.ToSimpleTypeName(value);
            return output;
        }

        public static ITypeName ToTypeName(this string value)
        {
            var output = StringOperator.Instance.ToTypeName(value);
            return output;
        }

        public static ITypeNameStem ToTypeNameStem(this string value)
        {
            var output = StringOperator.Instance.ToTypeNameStem(value);
            return output;
        }

        public static IEnumerable<ITypeNameStem> ToTypeNameStems(this IEnumerable<string> values)
        {
            var output = StringOperator.Instance.ToTypeNameStems(values);
            return output;
        }

        public static ITypeNamedMethodName ToTypeNamedMethodName(this string value)
        {
            var output = StringOperator.Instance.ToTypeNamedMethodName(value);
            return output;
        }
    }
}
