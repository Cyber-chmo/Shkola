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
        public UserControl1(Tema tema)
        {
            InitializeComponent(); 
            
            try
            {
                ThemeLabel.Text = System.IO.File.ReadAllText("../../../Files/Темы/" + tema.discipline + " " + tema.name + ".txt"); 
            }
            catch (Exception)
            {
                ThemeLabel.Text = "Такой темы нет";
            }
        }
    }
}
