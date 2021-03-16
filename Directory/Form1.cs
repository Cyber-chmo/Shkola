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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int x = 100;
            AllThemes lesch = new AllThemes();
            lesch.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // new ReadLaterForm().Show();
            ReadLaterForm aaa = new ReadLaterForm();
            aaa.Show();

        }
    }
}
