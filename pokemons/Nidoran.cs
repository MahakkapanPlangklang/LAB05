using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.pokemons
{
    internal class Nidoran : Pokemon
    {
        public Nidoran() 
        {
                this.name = "Nidoran";
                Random random = new Random();
                this.HP = random.Next(212,421);
                this._image = Properties.Resources.Nidoran;
                this.Attack = random.Next(118, 300);
                this.Defense = random.Next(123, 242);
            

        }
    }
}
