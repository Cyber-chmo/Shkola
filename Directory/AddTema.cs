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

            nameTB.Text = "";
            textBox1.Text = "";
            disciplineCombo.Text = "";
            domainUpDown1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        void translate(Dictionary<string, string> Words)
        {
            label2.Text = Words["Выбор предмета:"];
            //button2.Text = Words["Расширенный поиск"];
            button1.Text = Words["Поиск"];
            //button3.Text = Words["Смотреть позже"];

            //  System.Diagnostics.Process.Start("https://google.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.language == "Английский")
            {
                translate(Form1.EngWords);
            }
            else if (Form1.language == "Русский")
            {
                translate(Form1.RusWords);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
