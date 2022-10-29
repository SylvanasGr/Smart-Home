using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        static int countHelpButton;
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
            timer3.Start();

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

        private void toggleButtonCustom1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonCustom1.Checked)
            {
                panel4.BackColor = Color.LightYellow;
                label2.Text = "On";
                pictureBox7.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, @"C:\Users\Konstantinos\source\repos\Smart-Home\Smart-Home\Images\background-on.png"));

            }
            else
            {
                pictureBox7.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, @"C:\Users\Konstantinos\source\repos\Smart-Home\Smart-Home\Images\background-off.png"));
                panel4.BackColor = Color.Silver;
                label2.Text = "Off";
            }
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
            //alert
            System.Media.SoundPlayer alert_on = new System.Media.SoundPlayer();
            alert_on.SoundLocation = "C://Users/Konstantinos/source/repos/Smart-Home/Smart-Home/Images/abstract/sounds/alert-on.wav";
            System.Media.SoundPlayer alert_off = new System.Media.SoundPlayer();
            alert_off.SoundLocation = "C://Users/Konstantinos/source/repos/Smart-Home/Smart-Home/Images/abstract/sounds/alert-off.wav";
            if (toggleButtonCustom4.Checked)
            {
                panel13.BackColor = Color.Red;
                label9.Text = "On";
                alert_on.Play();    
            }
            else
            {
                panel13.BackColor = Color.Silver;
                label9.Text = "Off";
                alert_off.Play();   
            }
        }

        private void toggleButtonCustom3_CheckedChanged(object sender, EventArgs e)
        {
            //cameras
            System.Media.SoundPlayer camera_on = new System.Media.SoundPlayer();
            camera_on.SoundLocation = "C://Users/Konstantinos/source/repos/Smart-Home/Smart-Home/Images/abstract/sounds/camera-on.wav";
            System.Media.SoundPlayer camera_off = new System.Media.SoundPlayer();
            camera_off.SoundLocation = "C://Users/Konstantinos/source/repos/Smart-Home/Smart-Home/Images/abstract/sounds/camera-off.wav";
            if (toggleButtonCustom3.Checked)
            {
                panel11.BackColor = Color.LightSalmon;
                label7.Text = "On";
                camera_on.Play();
            }
            else
            {
                panel11.BackColor = Color.Silver;
                label7.Text = "Off";
                camera_off.Play();
            }
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
            panel15.Visible = true;

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
            panel15.Visible = true;

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

        private void toggleButtonCustom5_CheckedChanged(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C://Users/Konstantinos/source/repos/Smart-Home/Smart-Home/Images/abstract/sounds/vaccum.wav";


            if (toggleButtonCustom5.Checked)
            {
                panel15.BackColor = Color.LightSeaGreen;
                label13.Text = "On";
                player.Play();
            }
            else
            {
                panel15.BackColor = Color.Silver;
                label13.Text = "Off";
                player.Stop();
            }
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


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            checkTheList(textBox1.Text, "add");
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            checkTheList(textBox2.Text, "remove");
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TodoList todoList = new TodoList();
            this.Hide();
            todoList.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.skroutz.gr/c/3363/sneakers.html?from=catspan&o=%CF%80%CE%B1%CF%80%CE%BF%CF%85%CF%84%CF%83%CE%B9%CE%B1");
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this,"Κλείσιμο εφαρμογής?", "Τερματισμός Εφαρμογής", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            countHelpButton++;
            if (countHelpButton % 2 == 0)
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Konstantinos\source\repos\Smart-Home\Smart-Home\Images\abstract\opa.chm",HelpNavigator.TopicId,"1");
        }
    }
}

