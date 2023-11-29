using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Player
    {
        public string Name {  get; set; }
        public string Password { get; set; }

        public Player(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public  string GetCSV()
        {
            return Name + "," + Password;
        }
    }

}
