using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.pokemons
{
    internal class Caterpie : Pokemon
    {
       
        public Caterpie()
        {
            this.name = "Caterpie";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 294);
            this._image = Properties.Resources.Caterpie;
            this.Attack = random.Next(100, 200);
            this.Defense = random.Next(67, 185);
        }
    }
}
