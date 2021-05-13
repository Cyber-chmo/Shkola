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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // pictureBox1.Image;

        }

        private  void label4_Click(object sender, EventArgs e)
        {
            label1.Text = "Регистрация";
            label2.Text = "Введите логин";
            label3.Text = "Введите пароль";

            /*
            Label l = new Label();
            l.Location = new Point(100, 100);
            l.Visible = true;
            l.Text = "Повторите пароль ещё раз";
            l.Font = new Font("Candara Light", 18);

            ControlCollection.Add();

            */


        }
    }
}
