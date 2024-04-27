using System.Collections.Generic;

namespace Continental_App
{
    internal interface IContinent
    {
        List<Animal> Animals { get; }

        void CreateContienent();
    }
}