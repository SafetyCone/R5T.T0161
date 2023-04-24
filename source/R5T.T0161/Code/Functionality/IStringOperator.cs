using System;

using R5T.T0132;


namespace R5T.T0161
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ArgumentName ToArgumentName(string value)
        {
            var output = new ArgumentName(value);
            return output;
        }

        public AttributeTypeName ToAttributeTypeName(string value)
        {
            var output = new AttributeTypeName(value);
            return output;
        }

        public FullMethodName ToFullMethodName(string value)
        {
            var output = new FullMethodName(value);
            return output;
        }

        public FullPropertyName ToFullPropertyName(string value)
        {
            var output = new FullPropertyName(value);
            return output;
        }

        public GenericTypeArgumentName ToGenericTypeArgumentName(string value)
        {
            var output = new GenericTypeArgumentName(value);
            return output;
        }

        public KindMarkedFullPropertyName ToKindMarkedFullPropertyName(string value)
        {
            var output = new KindMarkedFullPropertyName(value);
            return output;
        }

        public KindMarkedFullMemberName ToKindMarkedFullMemberName(string value)
        {
            var output = new KindMarkedFullMemberName(value);
            return output;
        }

        public KindMarkedFullMethodName ToKindMarkedFullMethodName(string value)
        {
            var output = new KindMarkedFullMethodName(value);
            return output;
        }

        public MethodName ToMethodName(string value)
        {
            var output = new MethodName(value);
            return output;
        }

        public NamespaceName ToNamespaceName(string value)
        {
            var output = new NamespaceName(value);
            return output;
        }

        public NamespacedTypedMethodName ToNamespacedTypedMethodName(string value)
        {
            var output = new NamespacedTypedMethodName(value);
            return output;
        }

        public NamespacedTypedPropertyName ToNamespacedTypedPropertyName(string value)
        {
            var output = new NamespacedTypedPropertyName(value);
            return output;
        }

        public NamespacedTypedParameterizedMethodName ToNamespacedTypedParameterizedMethodName(string value)
        {
            var output = new NamespacedTypedParameterizedMethodName(value);
            return output;
        }

        public NamespacedTypeName ToNamespacedTypeName(string value)
        {
            var output = new NamespacedTypeName(value);
            return output;
        }

        public OutputTypeName ToOutputTypeName(string value)
        {
            var output = new OutputTypeName(value);
            return output;
        }

        public ParameterList ToParameterList(string value)
        {
            var output = new ParameterList(value);
            return output;
        }

        public Parameter ToParameter(string value)
        {
            var output = new Parameter(value);
            return output;
        }

        public SimplestMethodName ToSimplestMethodName(string value)
        {
            var output = new SimplestMethodName(value);
            return output;
        }

        public SimplePropertyName ToSimplePropertyName(string value)
        {
            var output = new SimplePropertyName(value);
            return output;
        }

        public SimpleMethodName ToSimpleMethodName(string value)
        {
            var output = new SimpleMethodName(value);
            return output;
        }

        public SimpleTypeName ToSimpleTypeName(string value)
        {
            var output = new SimpleTypeName(value);
            return output;
        }

        public TypeName ToTypeName(string value)
        {
            var output = new TypeName(value);
            return output;
        }

        public TypeNamedMethodName ToTypeNamedMethodName(string value)
        {
            var output = new TypeNamedMethodName(value);
            return output;
        }
    }
}
