using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.pokemons
{
    public class Pokemon
    {
        protected string name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int Speed;
        protected Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return this.name; }
        public int getHP() 
        {
            return this.HP;
                if (this.HP <= 0)
                {
                    MessageBox.Show("Please selecet new Pokemons");
                }
        }
    
        public int getAttack() { return this.Attack;}
        public  int getDefense() { return this.Defense;}
        public void takeDamage(int atk) 
        {
            int damage;
            if (this.Defense > atk)
            {
                damage = 10;
            }
            else
            {
                damage = atk - this.Defense;
            }
            this.HP = this.HP - damage;
        }
        public int getHP50()
        {   
            return this.HP + 50;
        }
        public int getDef50()
        {
            return this.Defense + 50;
        }
    }

}
