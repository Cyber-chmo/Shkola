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
            tems_list[1].name = "Одночлены и Многочлены";
            tems_list[1].label = label2;
            tems_list[1].tags = "Математика, одночлены";
            tems_list[2].name = "Биквадратные уравнения";
            tems_list[2].label = label3;
            tems_list[2].tags = "Математика, уравнения";

            for (int i = 0; i < 3; i++)
                tems_list[i].label.Text = tems_list[i].name;

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                tems_list[i].label.Visible = true;
                if (!tems_list[i].name.Contains(textBox1.Text) &&
                    !tems_list[i].tags.Contains(textBox1.Text))
                    tems_list[i].label.Visible = false;
              /*  if (!tems_list[i].tags.Contains(textBox2.Text))
                    tems_list[i].label.Visible = false;*/ 
            }
        }
    }
}
