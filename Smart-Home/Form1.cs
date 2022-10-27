using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckBox checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Appearance = System.Windows.Forms.Appearance.Button;
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.LightBlue;
            pictureBox6.BackColor = Color.LightBlue;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.PapayaWhip;
            pictureBox6.BackColor = Color.PapayaWhip;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightBlue;
            pictureBox5.BackColor = Color.LightBlue;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.PapayaWhip;
            pictureBox5.BackColor = Color.PapayaWhip;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.LightBlue;
            pictureBox4.BackColor = Color.LightBlue;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.PapayaWhip;
            pictureBox4.BackColor = Color.PapayaWhip;   
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
            pictureBox1.BackColor = Color.LightBlue;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.PapayaWhip;
            pictureBox1.BackColor = Color.LightBlue;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightBlue;
            panel8.BackColor = Color.LightBlue;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.PapayaWhip;
            panel8.BackColor = Color.LightBlue;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.LightBlue;
            panel6.BackColor = Color.LightBlue;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.PapayaWhip;
            panel6.BackColor = Color.PapayaWhip;

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.LightBlue;
            panel5.BackColor = Color.LightBlue;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.PapayaWhip;
            panel5.BackColor = Color.PapayaWhip;
        }

        private void panel1_MouseHover_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
            pictureBox1.BackColor = Color.LightBlue;

        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
            pictureBox1.BackColor = Color.LightBlue;
        }

        private void panel1_MouseLeave_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.PapayaWhip;
            pictureBox1.BackColor = Color.PapayaWhip;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.PapayaWhip;
            pictureBox1.BackColor = Color.PapayaWhip;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightBlue;
            panel2.BackColor = Color.LightBlue;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightBlue;
            panel2.BackColor = Color.LightBlue;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightBlue;
            panel3.BackColor = Color.LightBlue;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightBlue;
            panel3.BackColor = Color.LightBlue;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.PapayaWhip;
            panel2.BackColor = Color.PapayaWhip;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.PapayaWhip;
            panel2.BackColor = Color.PapayaWhip;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.PapayaWhip;
            panel3.BackColor = Color.PapayaWhip;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.PapayaWhip;
            panel3.BackColor = Color.PapayaWhip;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
