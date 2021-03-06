﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Directory
{
    public partial class DisciplineForm : Form
    {


     
        /// <summary>
        /// Выбранная тема
        /// </summary>
        Tema tema = new Tema();
        public DisciplineForm(string predmet)
        {
            InitializeComponent();

            Text = predmet;
            label1.Text = predmet;
            label3.Text = File.ReadAllText("../../../Files/" + predmet + ".txt");
            button3.Text = "Скачать учебник по " + predmet;


            comboBox1.Items.Clear();
            for (int i = 0; i < AllThemes.tems_list.Count; i++)
            {
                //Если у темы предмет совпал, добавляем в список
                if (AllThemes.tems_list[i].discipline == predmet)
                    comboBox1.Items.Add(AllThemes.tems_list[i].name);
            }

            //Запилить похожие темы


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
                    string[] liness = File.ReadAllLines("../../../Files/Темы/" + label1.Text + " " + comboBox1.Text + ".txt");

                    if (liness.Length > 10)
                    {
                        panel1.AutoScroll = true;
                        label3.AutoSize = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Такой темы нет");
                }
            }


            foreach (Tema tm in AllThemes.tems_list)
            {
                if (tm.discipline == label1.Text && 
                    tm.name == comboBox1.Text)
                {
                    tema = tm;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AllThemes.readLater.Add(tema);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tema.link))//tema.link =="" && tema.link == Null
                System.Diagnostics.Process.Start(tema.link);
            else
                MessageBox.Show("Нет никакого источника. Я придумал физику");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(tema.BookLink, "1.pdf");

            MessageBox.Show("Сохранено в 1.pdf");


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Запилить похожие темы
        }
    }
}
