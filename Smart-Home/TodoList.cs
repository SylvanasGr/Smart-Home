using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Home
{
    public partial class TodoList : Form
    {

        int counter = 0;
        static int countHelpButton;

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

        private void TodoList_Load(object sender, EventArgs e)
        {
            string header = "Δραστηριότητα" + "\t\t\t\tΤοποθεσία" + "\t\t\t\tΑφιξη" + "\t\t\t\tΔιάρκεια" + "\t\t\tΤρόπος Μετακίνησης";
            listBox1.Items.Add(header);
            /*if( list != null && list.Items != null && list.Items.Count>0)
            {
                listBox1.Items.AddRange(list.Items);
            }*/
            timer1.Start();
        }



        private void addNewAction()
        {

            string action = comboBox1.Text;
            string location = comboBox2.Text;
            string arrival = comboBox3.Text;
            string duration = comboBox4.Text;
            string moveMethod = comboBox5.Text;
            string aiAssistant = comboBox6.Text;
            if (!string.IsNullOrEmpty(action) && !string.IsNullOrEmpty(location) && !string.IsNullOrEmpty(arrival) && !string.IsNullOrEmpty(duration) && !string.IsNullOrEmpty(moveMethod) && !string.IsNullOrEmpty(aiAssistant))
            {
                //Πανεπιστήμιο +
                //Διασκέδαση +
                //Γυμναστήριο +
                //Φαγητό+

                int durrInt = int.Parse(duration.Trim());

                if (durrInt > 60 && (moveMethod == "Πόδια" || moveMethod == "Ποδήλατο") && aiAssistant == "Ναι" && !action.Contains("+"))
                {
                    DialogResult dialog = MessageBox.Show("Φαίνεται πως στην δραστηρίοτητα:  " + action + " θα κάτσετε περισσότερο απο " + duration + " λεπτα. \n Μήπως θα ήταν καλύτερο να μεταφερθείτε με κάποιο μεταφορίκο μέσο?", "Αυτόματος Βοηθός", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        MessageBox.Show("Παρακαλώ συμπληρώστε ξανά την εγγραφή σας", "Αυτόματος Βοηθός");
                    }
                    else
                    {
                        counter++;
                        string finalResult = counter + "." + action + "\t\t\t\t" + location + "\t\t\t\t" + arrival + "\t\t\t\t" + duration + "\t\t\t" + moveMethod;
                        comboBox7.Items.Add(finalResult);
                        listBox1.Items.Add(finalResult);
                    }
                }else if (action.Contains("+") && moveMethod != "Πόδια" && aiAssistant == "Ναι")
                {
                    DialogResult dialogResult = MessageBox.Show("Φαίνεται πως στην δραστηρίοτητα:  " + action + "θα ήταν καλύτερη επιλογή για την ύγεια σας να επιλέξετε να πάτε με τα πόδια. \n Θέλετε να σας αλλάξω την επιλογή τρόπου μετακίνησης σε --> Πόδια?", "Αυτόματος Βοηθός", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        moveMethod = "Πόδια";
                        counter++;
                        string finalResult = counter + "." + action + "\t\t\t\t" + location + "\t\t\t\t" + arrival + "\t\t\t\t" + duration + "\t\t\t" + moveMethod;
                        comboBox7.Items.Add(finalResult);
                        listBox1.Items.Add(finalResult);
                    }
                    else
                    {
                        counter++;
                        string finalResult = counter + "." + action + "\t\t\t\t" + location + "\t\t\t\t" + arrival + "\t\t\t\t" + duration + "\t\t\t" + moveMethod;
                        comboBox7.Items.Add(finalResult);
                        listBox1.Items.Add(finalResult);
                    }
                }
                else
                {
                    counter++;
                    string finalResult = counter + "." + action + "\t\t\t\t" + location + "\t\t\t\t" + arrival + "\t\t\t\t" + duration + "\t\t\t" + moveMethod;
                    comboBox7.Items.Add(finalResult);
                    listBox1.Items.Add(finalResult);
                }

            }
            else
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία.", "Αυτόματος Βοηθός");
            }


            /*if(listBox1.Items != null && counter >0)
            {
                list = new ListBox();
                list.Items.AddRange(listBox1.Items);
            }
            
        */

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
            //list.Items.Remove(comboBox7.Text);
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            addNewAction();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Κλείσιμο εφαρμογής?", "Τερματισμός Εφαρμογής", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countHelpButton++;
            if (countHelpButton % 2 == 0)
            {
                button5.BackColor = Color.Green;
            }
            else
            {
                button5.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Konstantinos\source\repos\Smart-Home\Smart-Home\Images\abstract\opa.chm",HelpNavigator.TopicId,"14");
        }
    }
}
