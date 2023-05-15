using System;

using R5T.T0131;


namespace R5T.T0161
{
    [ValuesMarker]
    public partial interface IConstructors : IValuesMarker
    {
        public Func<string, IFullMethodName> FullMethodName => StringOperator.Instance.ToFullMethodName;
        public Func<string, IKindMarkedFullPropertyName> KindMarkedFullPropertyName => StringOperator.Instance.ToKindMarkedFullPropertyName;
        public Func<string, INamespacedTypedParameterizedMethodName> NamespacedTypedParameterizedMethodName => StringOperator.Instance.ToNamespacedTypedParameterizedMethodName;
        public Func<string, INamespacedTypeName> NamespacedTypeName => StringOperator.Instance.ToNamespacedTypeName;
    }
}
