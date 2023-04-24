using System;


namespace R5T.T0161.Extensions
{
    public static class StringExtensions
    {
        public static ArgumentName ToArgumentName(this string value)
        {
            var output = StringOperator.Instance.ToArgumentName(value);
            return output;
        }

        public static AttributeTypeName ToAttributeTypeName(this string value)
        {
            var output = StringOperator.Instance.ToAttributeTypeName(value);
            return output;
        }

        public static FullMethodName ToFullMethodName(this string value)
        {
            var output = StringOperator.Instance.ToFullMethodName(value);
            return output;
        }

        public static FullPropertyName ToFullPropertyName(this string value)
        {
            var output = StringOperator.Instance.ToFullPropertyName(value);
            return output;
        }

        public static IGenericTypeArgumentName ToGenericTypeArgumentName(this string value)
        {
            var output = StringOperator.Instance.ToGenericTypeArgumentName(value);
            return output;
        }

        public static KindMarkedFullPropertyName ToKindMarkedFullPropertyName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullPropertyName(value);
            return output;
        }

        public static KindMarkedFullMemberName ToKindMarkedFullMemberName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullMemberName(value);
            return output;
        }

        public static KindMarkedFullMethodName ToKindMarkedFullMethodName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullMethodName(value);
            return output;
        }

        public static MethodName ToMethodName(this string value)
        {
            var output = StringOperator.Instance.ToMethodName(value);
            return output;
        }

        public static NamespaceName ToNamespaceName(this string value)
        {
            var output = StringOperator.Instance.ToNamespaceName(value);
            return output;
        }

        public static NamespacedTypedParameterizedMethodName ToNamespacedTypedParameterizedMethodName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypedParameterizedMethodName(value);
            return output;
        }

        public static NamespacedTypeName ToNamespacedTypeName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypeName(value);
            return output;
        }

        public static NamespacedTypedMethodName ToNamespacedTypedMethodName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypedMethodName(value);
            return output;
        }

        public static NamespacedTypedPropertyName ToNamespacedTypedPropertyName(this string value)
        {
            var output = StringOperator.Instance.ToNamespacedTypedPropertyName(value);
            return output;
        }

        public static OutputTypeName ToOutputTypeName(this string value)
        {
            var output = StringOperator.Instance.ToOutputTypeName(value);
            return output;
        }

        public static ParameterList ToParameterList(this string value)
        {
            var output = StringOperator.Instance.ToParameterList(value);
            return output;
        }

        public static Parameter ToParameter(this string value)
        {
            var output = StringOperator.Instance.ToParameter(value);
            return output;
        }

        public static SimplestMethodName ToSimplestMethodName(this string value)
        {
            var output = StringOperator.Instance.ToSimplestMethodName(value);
            return output;
        }

        public static SimpleMethodName ToSimpleMethodName(this string value)
        {
            var output = StringOperator.Instance.ToSimpleMethodName(value);
            return output;
        }

        public static SimplePropertyName ToSimplePropertyName(this string value)
        {
            var output = StringOperator.Instance.ToSimplePropertyName(value);
            return output;
        }

        public static SimpleTypeName ToSimpleTypeName(this string value)
        {
            var output = StringOperator.Instance.ToSimpleTypeName(value);
            return output;
        }

        public static TypeName ToTypeName(this string value)
        {
            var output = StringOperator.Instance.ToTypeName(value);
            return output;
        }

        public static TypeNamedMethodName ToTypeNamedMethodName(this string value)
        {
            var output = StringOperator.Instance.ToTypeNamedMethodName(value);
            return output;
        }
    }
}
