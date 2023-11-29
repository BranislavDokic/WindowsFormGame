using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        public void GetPlayer(string player)
        {
            labelWithNickName.Text = "Player: " + player;
        }
        private void buttonBreakout_Click(object sender, EventArgs e)
        {
            this.Close();
            BreakoutGame breakoutGame = new BreakoutGame();
            breakoutGame.ShowDialog();

        }
    }
}
