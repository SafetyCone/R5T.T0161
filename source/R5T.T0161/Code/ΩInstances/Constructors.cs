using System;


namespace R5T.T0161
{
    public class Constructors : IConstructors
    {
        #region Infrastructure

        public static IConstructors Instance { get; } = new Constructors();


        private Constructors()
        {
        }

        #endregion
    }
}
