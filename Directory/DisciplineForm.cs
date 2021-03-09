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
    public partial class DisciplineForm : Form
    {
        public DisciplineForm(string predmet)
        {
            InitializeComponent();

            Text = predmet;
            label1.Text = predmet;
            label3.Text = File.ReadAllText("../../../Files/" + predmet + ".txt");

            comboBox1.Items.Clear();
            for (int i = 0; i < AllThemes.tems_list.Count; i++)
            {
                //Если у темы предмет совпал, добавляем в список
                if (AllThemes.tems_list[i].discipline == predmet)
                    comboBox1.Items.Add(AllThemes.tems_list[i].name); 
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
