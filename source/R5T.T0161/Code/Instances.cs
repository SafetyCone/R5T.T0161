using System;


namespace R5T.T0161
{
    public static class Instances
    {
        public static IConstructors Constructors => T0161.Constructors.Instance;
        public static IConversionOperator ConversionOperator => T0161.ConversionOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;
    }
}