using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory
{
    public partial class AddTema : Form
    {
        public AddTema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("../../../Files/Список.txt", 
                Environment.NewLine
                +
                nameTB.Text + "; " + textBox1.Text + "; " + disciplineCombo.Text + "; " + domainUpDown1.Text + "; " + textBox3.Text);

            File.WriteAllText("../../../Files/Темы/" + disciplineCombo.Text + " " + nameTB.Text + ".txt", textBox4.Text);

            MessageBox.Show("Тема сохранена");
        }
    }
}
