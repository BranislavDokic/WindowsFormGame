using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {

        public List<Player> playerList = new();

        public Form1()
        {
            InitializeComponent();

            //playerList.Add(new Player("Branislav", "12345"));

        }
        public string fileOfPlayers = "playersFile.txt";
        public void Loud()
        {
            StreamReader sr = new StreamReader(fileOfPlayers);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] strings = line.Split(",");
                Player newPlayer = new(strings[0], strings[1]);
                playerList.Add(newPlayer);
                line = sr.ReadLine();

            }
            sr.Close();
        }
        private void buttonCreatAcc_Click(object sender, EventArgs e)
        {
            panelLogIn.SendToBack();
            panelLogIn.Visible = false;

        }

        private void buttonCreateYourAcc_Click(object sender, EventArgs e)
        {
           if (textBoxNewNick.Text != "" && textBoxNewPassword.Text != "")
           {
         
               Player newPlayer = new Player(textBoxNewNick.Text, textBoxNewPassword.Text);
               StreamWriter streamWriter = new StreamWriter(fileOfPlayers, true);
               streamWriter.WriteLine(newPlayer.GetCSV());
               streamWriter.Close();
               label5.Show();
               label5.ForeColor = Color.Green;
               label5.Text = "complit";
               textBoxNewNick.Clear();
               textBoxNewPassword.Clear();
               
           }
           else if (textBoxNewNick.Text == "" || textBoxNewPassword.Text == "")
           {
         
               label5.ForeColor = Color.Red;
               label5.Text = "you have to write";
               label5.Show();
         
           }
            
          
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            panelLogIn.BringToFront();
            panelLogIn.Visible = true;

        }

        private void buttonToLogIn_Click(object sender, EventArgs e)
        {
            Loud();
            foreach (Player player in playerList)
            {
                if (textBoxNickName.Text == player.Name && textBoxPassword.Text == player.Password)
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.GetPlayer(player.Name);
                    form2.ShowDialog();

                }
                else
                {

                    label8.Text = "Wrong Password or Nick name!";
                    label8.Show();

                }
            }
            textBoxNickName.Clear();
            textBoxPassword.Clear();
        }

        private void textBoxNickName_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void textBoxNewNick_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}