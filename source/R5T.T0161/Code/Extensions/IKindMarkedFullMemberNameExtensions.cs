using System;


namespace R5T.T0161.Extensions
{
    public static class IKindMarkedFullMemberNameExtensions
    {
        public static KindMarkedFullPropertyName AsKindMarkedFullPropertyName(this IKindMarkedFullMemberName kindMarkedFullMemberName)
        {
            return Instances.ConversionOperator.AsKindMarkedFullPropertyName(kindMarkedFullMemberName);
        }
    }
}
