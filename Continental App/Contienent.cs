using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continental_App
{
    abstract internal class Contienent
    {
        private List<Animal> _animals = new List<Animal>();

        protected Contienent() 
        {
            CreateContienent();

        }

        public List<Animal> Animals => _animals;

        public  abstract void CreateContienent();
    }
}
