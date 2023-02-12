using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.pokemons
{
    internal class Pikachu : Pokemon
    {
        public Pikachu() {
            this.name = "Pikachu";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(230,324);
            this._image = Properties.Resources.Pikachu;
            this.Attack = random.Next(116, 245);
            this.Defense = random.Next(117, 247);
        }

    }
}
