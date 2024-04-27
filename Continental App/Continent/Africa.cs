using Continental_App.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continental_App.Continent
{
    internal class Africa : Contienent
    {
        public override void CreateContienent()
        {
            Animals.Add(new Lion());
            Animals.Add(new Elephant());
        }
    }
}
