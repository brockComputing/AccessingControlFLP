using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessingControlFLP
{
    public partial class Form1 : Form
    {
        List<Button> blist = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button ab = new Button();
                ab.Size = new Size(100, 100);
                ab.Text = i.ToString();
                ab.BackColor = Color.AliceBlue;
                blist.Add(ab);
                flowLayoutPanel1.Controls.Add(ab);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            blist[2].BackColor = Color.Red;
        }
    }
}
