using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.pokemons
{
    public class Charmander : Pokemon
    {
        public Charmander() {
            
            this.name = "Charmander";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(124,364);
            this._image = Properties.Resources.Charmander;
            this.Attack = random.Next(90, 180);
            this.Defense = random.Next(1000, 1200);
        }       
    }
}
