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
    public partial class ReadLaterForm : Form
    {








        public ReadLaterForm()
        {
            InitializeComponent();






            int x = 30;
            int y = 10;
            Controls.Clear();
            for (int i = 0; i < AllThemes.readLater.Count; i++)
            {
                UserControl1 uc = new UserControl1(AllThemes.readLater[i]);
                uc.Location = new Point(x, y);
                
                // uc.Dock = DockStyle.Fill;
                Controls.Add(uc);

                x = x + 400;
                if (x > Width)
                {
                    x = 30;
                    y = y + 380;
                }
            }
        }
    }
}
