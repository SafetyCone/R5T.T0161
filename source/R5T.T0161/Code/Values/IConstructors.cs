using System;

using R5T.T0131;


namespace R5T.T0161
{
    [ValuesMarker]
    public partial interface IConstructors : IValuesMarker
    {
        public Func<string, FullMethodName> FullMethodName => StringOperator.Instance.ToFullMethodName;
        public Func<string, KindMarkedFullPropertyName> KindMarkedFullPropertyName => StringOperator.Instance.ToKindMarkedFullPropertyName;
        public Func<string, NamespacedTypedParameterizedMethodName> NamespacedTypedParameterizedMethodName => StringOperator.Instance.ToNamespacedTypedParameterizedMethodName;
        public Func<string, NamespacedTypeName> NamespacedTypeName => StringOperator.Instance.ToNamespacedTypeName;
    }
}
