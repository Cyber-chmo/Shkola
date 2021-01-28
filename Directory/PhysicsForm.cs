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
    public partial class PhysicsForm : Form
    {
        public PhysicsForm(string predmet)
        {
            InitializeComponent();

            Text = predmet;
            label1.Text = predmet;

            if (predmet == "Физика")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Введение");
                comboBox1.Items.Add("Трение");

                label3.Text = File.ReadAllText("../../../Files/Физика.txt"); 

               // pictureBox1.Load("../../../Pictures/Physics1.jpg");
              //  pictureBox2.Load("../../../Pictures/Physics2.jpg");
            }
            else if (predmet == "Русский язык")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Введение");
                comboBox1.Items.Add("Мозговая оболочка");
            }
            else if (predmet == "Алгебра")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Введение");
                comboBox1.Items.Add("Одночлены");
                comboBox1.Items.Add("Многочлены");
                comboBox1.Items.Add("Ещё что-то");
            }

        }

        private void PhysicsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Физика" &&
                comboBox1.Text == "Введение")
            {
                //MessageBox.Show("Согласовано. Вводите войска!");
                //pictureBox1.Load("../../Картинки/пр1.png");
            }
        }
    }
}
