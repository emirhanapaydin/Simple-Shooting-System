using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ateş_et_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 0;

            timer1.Enabled = false;
            timer2.Enabled = false;
            pictureBox2.Visible = false;
            timer4.Enabled = true;
            kutuy.Enabled = true;


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;

            }
            if (e.KeyCode == Keys.S)
            {
                timer2.Enabled = true;
                timer1.Enabled = false;


            }
            if (e.KeyCode == Keys.Space)
            {
                
                pictureBox2.Visible = true;
                timer5.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 2;
            if (pictureBox1.Top <= label3.Bottom)
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 2;
            if (pictureBox1.Bottom >= label4.Top)
            {
                timer2.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 15;
            timer4.Enabled = false;
            if (pictureBox2.Left >= label1.Left)
            {
                timer4.Enabled = true;
                timer5.Enabled = false;
                pictureBox2.Visible = false;

            }

            int coryp = pictureBox2.Location.Y;
            int corxp = pictureBox2.Location.X;
            int cory = label5.Location.Y;
            int cory2 = label6.Location.Y;
            int corx = label5.Location.X;
            int corx2 = label6.Location.X;
            if (coryp >= cory && coryp <= cory2 && pictureBox2.Left >= pictureBox3.Left)
            {
                int x = pictureBox1.Location.X;
                int y = pictureBox1.Location.Y;
                a++;
                label2.Text = a.ToString();
                timer4.Enabled = true;
                timer5.Enabled = false;
                pictureBox2.Location = new Point(x + 10, y - 3);
                pictureBox2.Visible = false;
               
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (a == 10)
            {
              
                timer1.Enabled = false;
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                kutuy.Enabled = false;
                kutuney.Enabled = false;
              
                MessageBox.Show("Kazandın!");
                this.Close();
                
                
            }
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int X = pictureBox2.Location.X;
            int Y = pictureBox2.Location.Y;

            pictureBox2.Location = new Point(x + 10, y - 3);
        }

        private void kutuy_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top += 1;
            if (pictureBox3.Bottom >= label8.Top)
            {
                kutuy.Enabled = false;
                kutuney.Enabled = true;
            }
            int x = pictureBox3.Location.X;
            int y = pictureBox3.Location.Y;
            label5.Location = new Point(x , y);
            label6.Location = new Point(x, y+50);
           
        }

        private void kutuney_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top -= 1;
            if (pictureBox3.Top <= label7.Bottom)
            {
                kutuy.Enabled = true;
                kutuney.Enabled = false;
               
            }
            int x = pictureBox3.Location.X;
            int y = pictureBox3.Location.Y;
            label5.Location = new Point(x, y);
            label6.Location = new Point(x, y + 50);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
