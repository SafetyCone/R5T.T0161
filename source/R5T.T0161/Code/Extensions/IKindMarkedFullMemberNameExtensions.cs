using System;


namespace R5T.T0161.Extensions
{
    public static class IKindMarkedFullMemberNameExtensions
    {
        public static IKindMarkedFullPropertyName AsKindMarkedFullPropertyName(this IKindMarkedFullMemberName kindMarkedFullMemberName)
        {
            return Instances.ConversionOperator.AsKindMarkedFullPropertyName(kindMarkedFullMemberName);
        }
    }
}
