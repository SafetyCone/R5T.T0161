using System;

using R5T.T0132;


namespace R5T.T0161
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IArgumentName ToArgumentName(string value)
        {
            var output = new ArgumentName(value);
            return output;
        }

        public IAttributeTypeName ToAttributeTypeName(string value)
        {
            var output = new AttributeTypeName(value);
            return output;
        }

        public IClassTypeName ToClassTypeName(string value)
        {
            var output = new ClassTypeName(value);
            return output;
        }

        public IFullMethodName ToFullMethodName(string value)
        {
            var output = new FullMethodName(value);
            return output;
        }

        public IFullPropertyName ToFullPropertyName(string value)
        {
            var output = new FullPropertyName(value);
            return output;
        }

        public IGenericTypeArgumentName ToGenericTypeArgumentName(string value)
        {
            var output = new GenericTypeArgumentName(value);
            return output;
        }

        public IInterfaceTypeName ToInterfaceTypeName(string value)
        {
            var output = new InterfaceTypeName(value);
            return output;
        }

        public IKindMarkedFullPropertyName ToKindMarkedFullPropertyName(string value)
        {
            var output = new KindMarkedFullPropertyName(value);
            return output;
        }

        public IKindMarkedFullMemberName ToKindMarkedFullMemberName(string value)
        {
            var output = new KindMarkedFullMemberName(value);
            return output;
        }

        public IKindMarkedFullMethodName ToKindMarkedFullMethodName(string value)
        {
            var output = new KindMarkedFullMethodName(value);
            return output;
        }

        public IMethodName ToMethodName(string value)
        {
            var output = new MethodName(value);
            return output;
        }

        public INamespaceName ToNamespaceName(string value)
        {
            var output = new NamespaceName(value);
            return output;
        }

        public INamespacedTypedMethodName ToNamespacedTypedMethodName(string value)
        {
            var output = new NamespacedTypedMethodName(value);
            return output;
        }

        public INamespacedTypedPropertyName ToNamespacedTypedPropertyName(string value)
        {
            var output = new NamespacedTypedPropertyName(value);
            return output;
        }

        public INamespacedTypedParameterizedMethodName ToNamespacedTypedParameterizedMethodName(string value)
        {
            var output = new NamespacedTypedParameterizedMethodName(value);
            return output;
        }

        public INamespacedTypeName ToNamespacedTypeName(string value)
        {
            var output = new NamespacedTypeName(value);
            return output;
        }

        public IOutputTypeName ToOutputTypeName(string value)
        {
            var output = new OutputTypeName(value);
            return output;
        }

        public IOutputTypeNamed ToOutputTypeNamed(string value)
        {
            var output = new OutputTypeNamed(value);
            return output;
        }

        public IParameterList ToParameterList(string value)
        {
            var output = new ParameterList(value);
            return output;
        }

        public IParameter ToParameter(string value)
        {
            var output = new Parameter(value);
            return output;
        }

        public ISimplestMethodName ToSimplestMethodName(string value)
        {
            var output = new SimplestMethodName(value);
            return output;
        }

        public ISimplePropertyName ToSimplePropertyName(string value)
        {
            var output = new SimplePropertyName(value);
            return output;
        }

        public ISimpleMethodName ToSimpleMethodName(string value)
        {
            var output = new SimpleMethodName(value);
            return output;
        }

        /// <inheritdoc cref="ISimpleTypeName"/>
        public ISimpleTypeName ToSimpleTypeName(string value)
        {
            var output = new SimpleTypeName(value);
            return output;
        }

        public ITypeName ToTypeName(string value)
        {
            var output = new TypeName(value);
            return output;
        }

        public ITypeNameStem ToTypeNameStem(string value)
        {
            var output = new TypeNameStem(value);
            return output;
        }

        public ITypeNamedMethodName ToTypeNamedMethodName(string value)
        {
            var output = new TypeNamedMethodName(value);
            return output;
        }
    }
}
