using System;

using R5T.T0132;


namespace R5T.T0161
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ArgumentName ToArgumentName_WithoutValidation(string value)
        {
            var output = new ArgumentName(value);
            return output;
        }

        public AttributeTypeName ToAttributeTypeName_WithoutValidation(string value)
        {
            var output = new AttributeTypeName(value);
            return output;
        }

        public FullMethodName ToFullMethodName_WithoutValidation(string value)
        {
            var output = new FullMethodName(value);
            return output;
        }

        public GenericTypeArgumentName ToGenericTypeArgumentName_WithoutValidation(string value)
        {
            var output = new GenericTypeArgumentName(value);
            return output;
        }

        public KindMarkedFullMemberName ToKindMarkedFullMemberName_WithoutValidation(string value)
        {
            var output = new KindMarkedFullMemberName(value);
            return output;
        }

        public KindMarkedFullMethodName ToKindMarkedFullMethodName_WithoutValidation(string value)
        {
            var output = new KindMarkedFullMethodName(value);
            return output;
        }

        public MethodName ToMethodName_WithoutValidation(string value)
        {
            var output = new MethodName(value);
            return output;
        }

        public NamespaceName ToNamespaceName_WithoutValidation(string value)
        {
            var output = new NamespaceName(value);
            return output;
        }

        public TypeName ToTypeName_WithoutValidation(string value)
        {
            var output = new TypeName(value);
            return output;
        }

        public TypeNamedMethodName ToTypeNamedMethodName_WithoutValidation(string value)
        {
            var output = new TypeNamedMethodName(value);
            return output;
        }
    }
}
