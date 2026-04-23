using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // globale de spelers en random aanmaken
        private Random _will = new Random();
        
        private Speler _pl1 = new Speler();
        private Speler _pl2 = new Speler();
        private int hp = 100;

        private void Form1_Load(object sender, EventArgs e)
        {

            int pos = _will.Next(1, 501);
            int hp = 100;
            Speler _pl1 = new Speler(hp, pos, pos, true, "mario");
            Speler _pl2 = new Speler(hp, pos, pos, true, "luigi");










        }

       
        private void buttonValAan1_Click(object sender, EventArgs e)
        {

            // knop aanval player 1 tegen player 2
            Speler _pl1 = new Speler(hp, pos, pos, true, "mario");

            
        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            // button om posities te laten zien
        }

        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            // speler 1 genees
        }

        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            // aanval speler 2 tege speler 1
            Speler _pl2 = new Speler(hp, pos, pos, true, "mario");
        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            //  speler 2 genees
        }
    }
}
