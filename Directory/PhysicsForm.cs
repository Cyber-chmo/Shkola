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
            label3.Text = File.ReadAllText("../../../Files/" + predmet + ".txt");

            if (predmet == "Физика")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Введение");
                comboBox1.Items.Add("Трение");

                //label3.Text = File.ReadAllText("../../../Files/Физика.txt"); 

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
                comboBox1.Items.Add("Одночлены и Многочлены");
                comboBox1.Items.Add("Квадратные уравнения");
                comboBox1.Items.Add("Биквадратные уравнения");
                comboBox1.Items.Add("Неполные квадратные уравнения");

            }
            else if (predmet == "Геометрия")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Введение");
                comboBox1.Items.Add("Прямая. Углы.");
                comboBox1.Items.Add("Нет");
                comboBox1.Items.Add("Ещё что-то");
            }
            else if (predmet == "Химия")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Введение");
                comboBox1.Items.Add("О");
                comboBox1.Items.Add("О2");
                comboBox1.Items.Add("О3");
            }





        }

        private void PhysicsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            { 
                try
                {
                    label3.Text = File.ReadAllText("../../../Files/Темы/" + label1.Text + " " + comboBox1.Text + ".txt");
                }
                catch (Exception) 
                {
                    MessageBox.Show("Такой темы нет");
                }
            }
        }
    }
}
