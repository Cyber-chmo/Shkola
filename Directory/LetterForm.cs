using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory
{
    public partial class LetterForm : Form
    {
        public LetterForm()
        {
            InitializeComponent();







        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Выберите тему");
            } 
            if (textBox1.Text == "")
            {
                MessageBox.Show("Напишите письмо");
            }







            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("ukrain.bimba@gmail.com", "✪ ω ✪");
            // кому отправляем
            MailAddress to = new MailAddress("ukrain.bimba@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = comboBox1.Text;
            // текст письма
            m.Body = textBox1.Text +
                Environment.NewLine +
                Environment.NewLine + "Контакт:" + textBox2.Text;

            // приложение файла
            if (address != "")
            {
                Attachment attachment = new Attachment(address);

                attachment.Name = "1.jpg";

                m.Attachments.Add(attachment);
                }
            
             
             /*
               // приложение файла
            m.Attachments.Add(new Attachment("1.pdf"));
              
            // текст письма
            m.Body = File.ReadAllText("Письмо.txt");
            // письмо представляет код html
            m.IsBodyHtml = true;
            */
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("ukrain.bimba@gmail.com", "chruchru");
            smtp.EnableSsl = true;
            smtp.Send(m);
            //  Console.Read();

            MessageBox.Show("Письмо отправлено👌");

        }


        string address = "";


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }
    }
}
