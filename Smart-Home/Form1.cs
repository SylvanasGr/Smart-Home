using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Smart_Home
{
    public partial class Form1 : Form
    {
        int count;
        int totalFood = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckBox checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            label11.Text = "";
            label12.Text = "";
            panel17.Visible = false;
            panel19.Visible = false;
            

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

        private void toggleButtonCustom1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonCustom1.Checked)
            {
                panel4.BackColor = Color.LightYellow;
                label2.Text = "On";
            }
            else
            {
                panel4.BackColor = Color.Silver;
                label2.Text = "Off";
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toggleButtonCustom2_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonCustom2.Checked)
            {
                panel9.BackColor = Color.LightBlue;
                label5.Text = "On";
                timer1.Start();

            }
            else
            {
                panel9.BackColor = Color.Silver;
                label5.Text = "Off";
            }
        }

        private void toggleButtonCustom4_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonCustom4.Checked)
            {
                panel13.BackColor = Color.Red;
                label9.Text = "On";
            }
            else
            {
                panel13.BackColor = Color.Silver;
                label9.Text = "Off";
            }
        }

        private void toggleButtonCustom3_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonCustom3.Checked)
            {
                panel11.BackColor = Color.LightSalmon;
                label7.Text = "On";
            }
            else
            {
                panel11.BackColor = Color.Silver;
                label7.Text = "Off";
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)

        {

            label11.Text = "Κουζίνα";
            label12.Text = "35 C";
            panel4.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            toggleButtonCustom1.Checked = false;
            toggleButtonCustom2.Checked = false;
            toggleButtonCustom5.Checked = false;
            toggleButtonCustom6.Checked = false;
            label14.Text = "Καθαρισμός";
            panel19.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label11.Text = "Κουζίνα";
            label12.Text = "35 C";
            panel4.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            toggleButtonCustom1.Checked = false;
            toggleButtonCustom2.Checked = false;
            toggleButtonCustom5.Checked = false;
            toggleButtonCustom6.Checked = false;
            label14.Text = "Καθαρισμός";
            panel19.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("regergergerg");
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label11.Text = "Υπνοδωμάτιο";
            label12.Text = "25 C";
            label14.Text = "Κλιματισμός";
            panel15.Visible = true;
            panel17.Visible = false;
            panel4.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            toggleButtonCustom1.Checked = false;
            toggleButtonCustom2.Checked = false;
            toggleButtonCustom5.Checked = false;
            toggleButtonCustom6.Checked = false;
            label14.Text = "Καθαρισμός";
            panel19.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label11.Text = "Παπουτσοθήκη";
            label12.Text = "28 C";
            label14.Text = "Κλιματισμός";
            panel15.Visible = false;
            panel17.Visible = false;
            panel4.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            toggleButtonCustom1.Checked = false;
            toggleButtonCustom2.Checked = false;
            toggleButtonCustom5.Checked = false;
            toggleButtonCustom6.Checked = false;
            label14.Text = "Καθαρισμός";
            panel19.Visible = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label11.Text = "Μπάνιο";
            label12.Text = "16 C";
            label14.Text = "Κλιματισμός";
            panel15.Visible = true;
            panel17.Visible = false;
            panel4.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            toggleButtonCustom1.Checked = false;
            toggleButtonCustom2.Checked = false;
            toggleButtonCustom5.Checked = false;
            toggleButtonCustom6.Checked = false;
            label14.Text = "Καθαρισμός";
            panel19.Visible = false;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label11.Text = "Κατοικίδια";
            label12.Text = "32 C";
            panel15.Visible = false;
            label15.Text = "Τάισμα";
            panel17.Visible = true;
            panel4.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            toggleButtonCustom1.Checked = false;
            toggleButtonCustom2.Checked = false;
            toggleButtonCustom5.Checked = false;
            toggleButtonCustom6.Checked = false;
            panel19.Visible = false;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Text = "Κατοικίδια";
            label12.Text = "32 C";
            panel15.Visible = false;
            label15.Text = "Τάισμα";
            panel17.Visible = true;
            panel4.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            toggleButtonCustom1.Checked = false;
            toggleButtonCustom2.Checked = false;
            toggleButtonCustom5.Checked = false;
            toggleButtonCustom6.Checked = false;
            panel19.Visible = false;


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
        private void toggleButtonCustom6_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonCustom6.Checked)
            {

                if (totalFood >= 10)
                {
                    panel17.BackColor = Color.BlueViolet;
                    label16.Text = "On";
                    timer2.Start();
                }
                else
                {
                    timer2.Stop();
                    count = 0;
                    MessageBox.Show("Παρακαλώ πηγαίντε να δείτε την ποσότητα της τροφής.", "Χαμήλη Ποσότητα Τροφής");
                    toggleButtonCustom6.Checked = false;
                }

            }
            else
            {
                timer2.Stop();
                count = 0;
                panel17.BackColor = Color.Silver;
                label16.Text = "Off";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toggleButtonCustom5_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonCustom5.Checked)
            {
                panel15.BackColor = Color.LightSeaGreen;
                label13.Text = "On";
            }
            else
            {
                panel15.BackColor = Color.Silver;
                label13.Text = "Off";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (label12.Text != "")
            {
                String oldValue = label12.Text.Replace("C", "").Trim();
                int baseValue = int.Parse(oldValue);


                if (baseValue < 20)
                {
                    baseValue++;
                }
                else if (baseValue > 20)
                {
                    baseValue--;
                }
                else
                {
                    timer1.Stop();
                    toggleButtonCustom2.Checked = false;


                }
                label12.Text = baseValue.ToString() + " " + "C";
            }


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            if (count == 5 && totalFood > 10)
            {
                timer2.Stop();
                count = 0;
                totalFood -= 4;
                toggleButtonCustom6.Checked = false;
                MessageBox.Show("Το φαγητό μόλις σερβιρίστικε στα ζωακία επιτυχώς, μην ξεχάσετε να ανανεώσετε το φαγητό: " + totalFood + "%" + " απομένει ακόμα.", "Ενημέρωση Κατάστασης Ταΐσματος");

            }
            else
            {
                count++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue.Text = comboBox1.Text;
        }

        private void selectedValue_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            checkTheList(textBox1.Text, "add");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            checkTheList(textBox2.Text, "remove");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkTheList(String userChoice, String addOrRemove)
        {
            bool isExists = false;
            var arr = comboBox1.Items.Cast<Object>()
                  .Select(item => item.ToString()).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == userChoice)
                {
                    if (addOrRemove == "add")
                    {
                        MessageBox.Show("Η επιλογή: " + userChoice + " υπάρχει ήδη.");
                    }

                    isExists = true;
                }
            }
            if (String.IsNullOrEmpty(userChoice))
            {
                MessageBox.Show("Δεν επιτρέπεται η κενή επιλογή,παρακαλώ δώστε μια τιμή.", "Αποτροπή Ενέργειας");
                textBox1.Text = "";
                textBox2.Text = "";
                selectedValue.Text = "";
                return;
            }

            if (addOrRemove == "add" && !isExists)
            {
                comboBox1.Items.Add(userChoice);
                MessageBox.Show("Επιτυχής προσθήκη επιλογής: " + userChoice, "Προσθήκη Νέου Παπουτσίου");
                textBox1.Text = "";
            }

            if (addOrRemove == "remove")
                if (isExists)
                {
                    comboBox1.Items.Remove(userChoice);
                    MessageBox.Show("Επιτυχής αφαίρεση επιλογής: " + userChoice, "Αφαίρεση Καταχωρημένου Παπουτσίου");
                    textBox2.Text = "";
                    selectedValue.Text = "";
                }
                else
                {
                    MessageBox.Show("Ανεπιτυχής αφαίρεση επιλογής: " + userChoice + " η επιλογή δεν υπάρχει.", "Αποτροπή Ενέργειας.");
                    textBox2.Text = "";
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(selectedValue.Text))
            {
                MessageBox.Show("Η επιλογή που δώσατε: " + selectedValue.Text + " θα είναι διαθέσιμη σε 30 λεπτά.","Επιτυχής Επιλογή.");
            }
            else
            {
                MessageBox.Show("Δεν επιτρέπονται οι κενές επιλογές.","Αποτροπή Ενέργειας.");
            }

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TodoList todoList = new TodoList();
            this.Hide();
            todoList.Show();
        }
    }
}

