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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonPhysics.Checked)
            {
                PhysicsForm form = new PhysicsForm("Физика");
                form.Show();
            }
            if (radioButton1.Checked)
            {
                PhysicsForm form = new PhysicsForm("Русский язык");
                form.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
