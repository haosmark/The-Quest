using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateCharacters()
        {
            Player.Location = game.PlayerLocation;
            game.PlayerHitPoints.ToString();
            private bool showBat = false;
            private bool showGhost = false;
            private bool showGhoul = false;
            int enemiesShown = 0;
            // TODO
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
