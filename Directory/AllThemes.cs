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

        public Tema(string _name, string _tags, string _discipline, int _difficulty)
        {
            name = _name;
            picture = new PictureBox();
            label = new Label();
            tags = _tags;
            discipline = _discipline;
            difficulty = _difficulty;
        }

    }
    public partial class AllThemes : Form
    {
        //Tema[] tems_list = new Tema[300];

        /// <summary>
        /// Все темы программы
        /// </summary>
        public static List<Tema> tems_list = new List<Tema>();
        /// <summary>
        /// Читать позже
        /// </summary>
        public static List<Tema> readLater = new List<Tema>();



        public static void FillThemes()
        {
            //алгебра
            tems_list.Add(new Tema("Квадратные уравнения", "Математика, уравнения", "Алгебра", 2));
            tems_list.Add(new Tema("Одночлены и Многочлены", "Математика, одночлены", "Алгебра", 2));
            tems_list.Add(new Tema("Биквадратные уравнения", "Математика, уравнения", "Алгебра", 4));
            tems_list.Add(new Tema("Неполные квадратные уравнения", "Математика, уравнения", "Алгебра", 2));
            //физика
            tems_list.Add(new Tema("Плотность", "Физика, механика", "Физика", 2));
            tems_list.Add(new Tema("Сила тяжести", "Физика, механика", "Физика", 2));
            tems_list.Add(new Tema("Давление", "Физика, механика", "Физика", 2));
            tems_list.Add(new Tema("Архимедова сила", "Физика, механика", "Физика", 2));
            //Русский язык
            tems_list.Add(new Tema("Причастие", "Русский язык", "Русский язык", 2));
            tems_list.Add(new Tema("Деепричастие", "Русский язык", "Русский язык", 2));
            tems_list.Add(new Tema("Обобщающие слова", "Русский язык", "Русский язык", 2));
            tems_list.Add(new Tema("Односоставные предложения", "Русский язык", "Русский язык", 2));
            //Химия
           



        }

        public AllThemes()
        {
            InitializeComponent();

            int x = 30;
            int y = 10;
            for (int i = 0; i < tems_list.Count; i++)
            {
                tems_list[i].label.Size = new Size(200, 30);
                tems_list[i].label.Text = tems_list[i].name;
                tems_list[i].label.Font = new Font("Arial", 10);
                tems_list[i].label.Location = new Point(x, y);
                tems_list[i].label.Click += new EventHandler(ReadTheme);
                panel1.Controls.Add(tems_list[i].label);

                y = y + 30;
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 50;
            for (int i = 0; i < tems_list.Count; i++)
            {
                tems_list[i].label.Visible = true;
                if (themeTB.Text != "" &&
                    !tems_list[i].name.ToUpper().Contains(themeTB.Text.ToUpper()))
                {
                     tems_list[i].label.Visible = false;
                }

                if (tagsTB.Text != "" &&
                    !tems_list[i].tags.ToUpper().Contains(tagsTB.Text.ToUpper()))
                {
                     tems_list[i].label.Visible = false; 
                }

                if (tems_list[i].label.Visible)
                {
                    tems_list[i].label.Location = new Point(x, y);
                    y = y + 30;
                }
                   
            }
        }

        private void ReadTheme(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            //MessageBox.Show(lbl.Text);
            foreach (Tema tema in tems_list)
            {
                if (lbl.Text == tema.name)
                {
                    try
                    {
                        ThemeLabel.Text = System.IO.File.ReadAllText("../../../Files/Темы/" + tema.discipline + " " + lbl.Text + ".txt");
                    }
                    catch (Exception)
                    {
                        ThemeLabel.Text = "Такой темы нет";
                    }
                }
            }
        }
    }
}
