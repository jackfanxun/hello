using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxinput1.Text);
            var y = int.Parse(this.textBoxinput2.Text);
            var z = x + y;
            this.textBoxresult.Text= z.ToString();
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxinput1.Text);
            var y = int.Parse(this.textBoxinput2.Text);
            var z = x - y;
            this.textBoxresult.Text = z.ToString();
        }

        private void buttoncheng_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxinput1.Text);
            var y = int.Parse(this.textBoxinput2.Text);
            var z = x * y;
            this.textBoxresult.Text = z.ToString();
        }

        private void buttonchu_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxinput1.Text);
            var y = int.Parse(this.textBoxinput2.Text);
            if (y != 0)
            {
                var z = x / y;
                this.textBoxresult.Text = z.ToString();
            }
            else {
                this.textBoxresult.Text = "0不能做除数";
            }
           
        }
    }
}
