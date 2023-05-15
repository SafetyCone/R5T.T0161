using System;

using R5T.T0132;
using R5T.T0179.Extensions;


namespace R5T.T0161
{
    [FunctionalityMarker]
    public partial interface IConversionOperator : IFunctionalityMarker
    {
        public IKindMarkedFullPropertyName AsKindMarkedFullPropertyName(IKindMarkedFullMemberName kindMarkedFullMemberName)
        {
            var output = kindMarkedFullMemberName.As(Instances.Constructors.KindMarkedFullPropertyName);
            return output;
        }
    }
}
