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
        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();
        public static string language = "Русский"; 
        public Form1()
        {
            InitializeComponent();
            //Заполнение словарей
            EngWords.Add("Расширенный поиск", "Global Search");
            EngWords.Add("Выбор предмета:", "Choose the subject");
            EngWords.Add("Поиск", "Search");
            EngWords.Add("Смотреть позже", "Read later");

            RusWords.Add("Расширенный поиск", "Расширенный поиск");
            RusWords.Add("Выбор предмета:", "Выбор предмета:");
            RusWords.Add("Поиск", "Поиск");
            RusWords.Add("Смотреть позже", "Смотреть позже");

            language = Properties.Settings.Default.language;
            if (language == "Английский")
                translate(EngWords);
        }

        void translate (Dictionary<string, string> Words)
        {
            label2.Text = Words["Выбор предмета:"];
            button2.Text = Words["Расширенный поиск"];
            button1.Text = Words["Поиск"];
            button3.Text = Words["Смотреть позже"];
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
            AllThemes lesch = new AllThemes("Все темы");
            lesch.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // new ReadLaterForm().Show();
            AllThemes lesch = new AllThemes("Читать позже");
            lesch.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            language = "Русский";
            translate(RusWords);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            language = "Английский";
            translate(EngWords);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.language = language;
            Properties.Settings.Default.Save();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddTema addtema = new AddTema();
            addtema.Show();
        }



        
        int startTime = 0;
        private void хочуДобавитьТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
             

            button6.Visible = true;
            startTime = Environment.TickCount;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentTime = Environment.TickCount;
            label4.Text = DateTime.Now.ToLongTimeString(); 

            if (currentTime - startTime > 3000)
                button6.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReadLaterForm RL = new ReadLaterForm();
            RL.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AuthForm AF = new AuthForm();
            AF.ShowDialog();
        }
    }
}
