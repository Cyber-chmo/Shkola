using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory
{
    public partial class UserControl1 : UserControl
    {
        Tema tema;
        public UserControl1(Tema tema1)
        {
            tema = tema1;
            InitializeComponent(); 
            

          //  label1.Text = 

            try
            {
                ThemeLabel.Text = System.IO.File.ReadAllText("../../../Files/Темы/" + tema.discipline + " " + tema.name + ".txt"); 
            }
            catch (Exception)
            {
                ThemeLabel.Text = "Такой темы нет";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AllThemes.readLater.Remove(tema);
            this.Parent = null;
        }
    }
}
