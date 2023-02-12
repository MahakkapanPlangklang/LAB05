using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.pokemons
{
    internal class Wartortle : Pokemon
    {
        public Wartortle()
        {
            this.name = "Wartortle";
            Random random = new Random();
            this.HP = random.Next(250, 400);
            this._image = Properties.Resources.Wartortle;
            this.Attack = random.Next(120, 250);
            this.Defense = random.Next(119, 230);
        }
    }
}
