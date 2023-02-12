using   LAB05.pokemons;
using System.Windows.Forms;
namespace LAB05
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemon>();
            pokemons.Add(new Pikachu());
            pokemons.Add(new Charmander());
            pokemons.Add(new Wartortle());
            pokemons.Add(new Nidoran());



            this.monster = new Caterpie();
            this.pictureBox2.Image = this.monster.getImage();
            this.eName.Text = this.monster.getName();
            this.eHP.Text = this.monster.getHP().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     
        private void Attack_Click(object sender, EventArgs e)
        {
            int a = Math.Abs(this.monster.getDefense() - this.selectedPokemon.getAttack());
            this.monster.takeDamage(a);
            this.eHP.Text = monster.getHP().ToString();
            if (monster.getHP() <= 0)
            {
                MessageBox.Show("WIN");
                Application.Exit();
            }
        }

        private void heal_Click(object sender, EventArgs e)
        {
            this.mpHP.Text = this.selectedPokemon.getHP50().ToString();
            heal.Enabled = false;
        }

        private void defense_Click(object sender, EventArgs e)
        {
            this.selectedPokemon.getDef50();
            defense.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int atk = Math.Abs(this.selectedPokemon.getDefense() - this.monster.getAttack());
            this.selectedPokemon.takeDamage(atk);
            this.mpHP.Text = selectedPokemon.getHP().ToString();
            if (pokemons[0].getHP() <= 0)
            {
                P.Enabled = false;
            }
            else if (pokemons[1].getHP() <= 0)
            {
                C.Enabled = false;
            }
            else if (pokemons[2].getHP() <= 0)
            {
                W.Enabled = false;
                

            }
            else if (pokemons[3].getHP() <= 0)
            {
                N.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.eHP.Text = this.monster.getHP50().ToString();
            button3.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.monster.getDef50();
            button7.Enabled = false;
        }

        private void P_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.mpName.Text = selectedPokemon.getName();
            this.mpHP.Text = selectedPokemon.getHP().ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.mpName.Text = selectedPokemon.getName();
            this.mpHP.Text = selectedPokemon.getHP().ToString();
        }

        private void W_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.mpName.Text = selectedPokemon.getName();
            this.mpHP.Text = selectedPokemon.getHP().ToString();
        }

        private void N_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.mpName.Text = selectedPokemon.getName();
            this.mpHP.Text = selectedPokemon.getHP().ToString();
        }
    }
}