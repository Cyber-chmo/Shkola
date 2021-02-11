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
    public struct Tema
    {
        public string name;
        public PictureBox picture;
        public Label label;
        public string tags;
        public string discipline;
        public int difficulty;

    }
    public partial class Form2 : Form
    {
        Tema[] tems_list = new Tema[3];





        public Form2()
        {
            InitializeComponent();

            tems_list[0].name = "Квадратные уравнения";
            tems_list[0].label = label1;
            tems_list[0].tags = "Математика, уравнения";
            tems_list[0].discipline = "Математика";
            tems_list[0].difficulty = 2;

            tems_list[1].name = "Одночлены и Многочлены";
            tems_list[1].label = label2;
            tems_list[1].tags = "Математика, одночлены";
            tems_list[1].discipline = "Математика";
            tems_list[1].difficulty = 2;

            tems_list[2].name = "Биквадратные уравнения";
            tems_list[2].label = label3;
            tems_list[2].tags = "Математика, уравнения";
            tems_list[2].discipline = "Математика";
            tems_list[2].difficulty = 4;

            tems_list[0].name = "Неполные квадратные уравнения";
            tems_list[0].label = label1;
            tems_list[0].tags = "Математика, уравнения";
            tems_list[0].discipline = "Математика";
            tems_list[0].difficulty = 2;

            for (int i = 0; i < 3; i++)
            {
                tems_list[i].label.Text = tems_list[i].name;
                tems_list[i].label.Font = new Font("Arial", 15);
                tems_list[i].label.Location = new Point(30, 50 + 40 * i);
            }

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                tems_list[i].label.Visible = true;
                if (themeTB.Text != "" &&
                    !tems_list[i].name.ToUpper().Contains(themeTB.Text.ToUpper()))
                    tems_list[i].label.Visible = false;

                if (tagsTB.Text != "" &&
                    !tems_list[i].tags.ToUpper().Contains(tagsTB.Text.ToUpper()))
                    tems_list[i].label.Visible = false; 




            }
        }
    }
}
