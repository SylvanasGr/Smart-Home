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
    public partial class TodoList : Form
    {

        int counter = 0;
        public TodoList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TodoList_Load(object sender, EventArgs e)
        {
            string header = "Δραστηριότητα" + "\t\t\t\tΤοποθεσία" + "\t\t\t\tΑφιξη" + "\t\t\t\tΔιάρκεια" + "\t\t\tΤρόπος Μετακίνησης";
            listBox1.Items.Add(header);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void addNewAction()
        {

            string action = comboBox1.Text;
            string location = comboBox2.Text;
            string arrival = comboBox3.Text;
            string duration = comboBox4.Text;
            string moveMethod = comboBox5.Text;
            string aiAssistant = comboBox6.Text;
            if (string.IsNullOrEmpty(action) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(arrival) || string.IsNullOrEmpty(duration) || string.IsNullOrEmpty(moveMethod) || string.IsNullOrEmpty(aiAssistant))
            {
                counter++;
                string finalResult = counter + "." + action + "\t\t\t\t" + location + "\t\t\t\t" + arrival + "\t\t\t\t" + duration + "\t\t\t" + moveMethod;
                comboBox7.Items.Add(finalResult);
                listBox1.Items.Add(finalResult);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNewAction();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(comboBox7.Text);
            comboBox7.Items.Remove(comboBox7.Text);
            comboBox7.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
