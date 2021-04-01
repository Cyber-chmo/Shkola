﻿using System;
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
        public string link;

        public Tema(string _name, string _tags, string _discipline, int _difficulty, string _link)
        {
            name = _name;
            picture = new PictureBox();
            label = new Label();
            tags = _tags;
            discipline = _discipline;
            difficulty = _difficulty;
            link = _link;
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
        
        /// <summary>
        /// Темы, которые тут выводятся (все или отложенные)
        /// </summary>
        List<Tema> themes = new List<Tema>();



        public static void FillThemes()
        {
            //алгебра
            tems_list.Add(new Tema("Квадратные уравнения", "Математика, уравнения", "Алгебра", 2, ""));
            tems_list.Add(new Tema("Одночлены и Многочлены", "Математика, одночлены", "Алгебра", 2, ""));
            tems_list.Add(new Tema("Биквадратные уравнения", "Математика, уравнения", "Алгебра", 4, ""));
            tems_list.Add(new Tema("Неполные квадратные уравнения", "Математика, уравнения", "Алгебра", 2, ""));
            //физика
            tems_list.Add(new Tema("Плотность", "Физика, механика", "Физика", 2, ""));
            tems_list.Add(new Tema("Сила тяжести", "Физика, механика", "Физика", 2, ""));
            tems_list.Add(new Tema("Давление", "Физика, механика", "Физика", 2, ""));
            tems_list.Add(new Tema("Архимедова сила", "Физика, механика", "Физика", 2, ""));
            //Русский язык
            tems_list.Add(new Tema("Причастие", "Русский язык", "Русский язык", 2, ""));
            tems_list.Add(new Tema("Деепричастие", "Русский язык", "Русский язык", 2, ""));
            tems_list.Add(new Tema("Обобщающие слова", "Русский язык", "Русский язык", 2, ""));
            tems_list.Add(new Tema("Односоставные предложения", "Русский язык", "Русский язык", 2, ""));
            //Химия
            tems_list.Add(new Tema("Количество вещества", "Химия", "Химия", 2, "https://www.yaklass.ru/p/himija/89-klass/raschetnye-zadachi-po-khimii-14608/vychislenie-kolichestva-veshchestva-227644/re-43cb784f-e2d0-437e-a4a8-8b32bf44060b"));



        }

        void translate (Dictionary<string, string> Words)
        {
            label2.Text = Words["Выбор предмета:"];
            //button2.Text = Words["Расширенный поиск"];
            button1.Text = Words["Поиск"];
            //button3.Text = Words["Смотреть позже"];

            System.Diagnostics.Process.Start("https://google.com");
        }

        public AllThemes(string s)
        {
            if (s == "Все темы")
                for (int i = 0; i < tems_list.Count; i++)
                {
                    themes.Add(tems_list[i]);
                }
            else
                for (int i = 0; i < readLater.Count; i++)
                {
                    Tema tema = new Tema(readLater[i].name, readLater[i].tags, readLater[i].discipline, readLater[i].difficulty, readLater[i].link);
                    themes.Add(tema);
                }

            InitializeComponent();


            if (Form1.language == "Английский")
            {
                translate(Form1.EngWords);
            }
            else if (Form1.language == "Русский")
            {
                translate(Form1.RusWords);
            }


            int x = 30;
            int y = 10;
            for (int i = 0; i < themes.Count; i++)
            {
                themes[i].label.Size = new Size(200, 30);
                themes[i].label.Text = themes[i].name;
                themes[i].label.Font = new Font("Arial", 10);
                themes[i].label.Location = new Point(x, y);
                themes[i].label.Click += new EventHandler(ReadTheme);
                panel1.Controls.Add(themes[i].label);

                y = y + 30;
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 10;
            for (int i = 0; i < themes.Count; i++)
            {
                themes[i].label.Visible = true;
                if (themeTB.Text != "" &&
                    !themes[i].name.ToUpper().Contains(themeTB.Text.ToUpper()))
                {
                    themes[i].label.Visible = false;
                }

                if (tagsTB.Text != "" &&
                    !themes[i].tags.ToUpper().Contains(tagsTB.Text.ToUpper()))
                {
                    themes[i].label.Visible = false; 
                }

                if (themes[i].label.Visible)
                {
                    themes[i].label.Location = new Point(x, y);
                    y = y + 30;
                }
                   
            }
        }

        private void ReadTheme(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            //MessageBox.Show(lbl.Text);
            foreach (Tema tema in themes)
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

        private void themeTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

        private void tagsTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }
    }
}
