using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonbutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point yer = new Point(10,10);
            btn.Location = yer;
            btn.Text = "buton gercek";
            btn.Name = "arkabuton";
            btn.BackColor = Color.Green;
            btn.Height = 75;
            btn.Width = 75;
          

            Label lbl = new Label();
            Point adres = new Point(80,40);
            lbl.Location = adres;
            lbl.Text = "merhaba hacım";
            lbl.Name = "hayvan";
            lbl.BackColor = Color.Blue;
            lbl.AutoSize = false;

            this.Controls.Add(btn);
            this.Controls.Add(lbl);

            for (int i = 0; i < 5; i++)
            {
                TextBox txt = new TextBox();
                Point mbr = new Point(200,i*30);
                txt.Location = mbr;
                txt.Text = "textbox" + i;
                txt.Name = "textboxOluk" + i;
                this.Controls.Add(txt);
            }
        }
    }
}
