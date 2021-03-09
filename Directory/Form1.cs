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

        void OpenPredmet(RadioButton rb)
        {
            if (rb.Checked)
            {
                DisciplineForm klesch = new DisciplineForm(rb.Text);
                klesch.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //                             все, что лежит на панели1
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is RadioButton)
                    OpenPredmet((RadioButton)ctrl);
            }


            /*
            OpenPredmet(radioButton4);
            OpenPredmet(radioButton1);
            OpenPredmet(radioButton2);
            OpenPredmet(radioButton3);
            OpenPredmet(radioButton5);

            if (radioButtonPhysics.Checked)
            {
                PhysicsForm form = new PhysicsForm(radioButtonPhysics.Text);
                form.Show();
            }
            if (radioButton1.Checked)
            {
                PhysicsForm form = new PhysicsForm("Русский язык");
                form.Show();
            }
            if (radioButton2.Checked)
            {
                PhysicsForm form = new PhysicsForm("Алгебра");
                form.Show();
            }
            if (radioButton3.Checked)
            {
                PhysicsForm form = new PhysicsForm("Геометрия");
                form.Show();
            }
            if (radioButton5.Checked)
            {
                PhysicsForm form = new PhysicsForm("Химия");
                form.Show();
            }*/



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllThemes lesch = new AllThemes();
            lesch.Show();
        }
    }
}
