using System;


namespace R5T.T0161.Extensions
{
    public static class StringExtensions
    {
        public static ArgumentName ToArgumentName(this string value)
        {
            var output = StringOperator.Instance.ToArgumentName_WithoutValidation(value);
            return output;
        }

        public static FullMethodName ToFullMethodName(this string value)
        {
            var output = StringOperator.Instance.ToFullMethodName_WithoutValidation(value);
            return output;
        }

        public static GenericTypeArgumentName ToGenericTypeArgumentName(this string value)
        {
            var output = StringOperator.Instance.ToGenericTypeArgumentName_WithoutValidation(value);
            return output;
        }

        public static KindMarkedFullMemberName ToKindMarkedFullMemberName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullMemberName_WithoutValidation(value);
            return output;
        }

        public static KindMarkedFullMethodName ToKindMarkedFullMethodName(this string value)
        {
            var output = StringOperator.Instance.ToKindMarkedFullMethodName_WithoutValidation(value);
            return output;
        }

        public static MethodName ToMethodName(this string value)
        {
            var output = StringOperator.Instance.ToMethodName_WithoutValidation(value);
            return output;
        }

        public static TypeName ToTypeName(this string value)
        {
            var output = StringOperator.Instance.ToTypeName_WithoutValidation(value);
            return output;
        }

        public static TypeNamedMethodName ToTypeNamedMethodName(this string value)
        {
            var output = StringOperator.Instance.ToTypeNamedMethodName_WithoutValidation(value);
            return output;
        }
    }
}
