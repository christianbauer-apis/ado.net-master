using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }


     
        private void Submitbutton_Click(object sender, EventArgs e)
        {
        
///////////////////////////
            try
            {
                if (nameTextBox.Text != "")
                {
                    if (addressTextBox.Text != "")
                    {
                        if (phoneTextBox.Text != "")
                        {
                            Patient pat = new Patient(nameTextBox.Text, addressTextBox.Text, phoneTextBox.Text, dobDateTimePicker.Value, dobDateTimePicker.Value, dobDateTimePicker.Value);
                            if (pat.addPatient(pat) > 0)
                            {
                                MessageBox.Show("Success.");
                                MessageBox.Show(pat.getPID());
                                MedicalForm mf = new MedicalForm();
                                mf.ShowDialog();
                               // Patient p = new Patient();
                             
                            }

                        }
                        else { MessageBox.Show("Please enter a phone number."); }
                    }
                    else { MessageBox.Show("Please enter an address."); }
                }
                else
                {
                    MessageBox.Show("Please enter a name");
                }
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
                 
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }
  

        private void Updatebutton_Click(object sender, EventArgs e)
        {


            /////////////////////////////////
            Patient p = new Patient(nameTextBox.Text, addressTextBox.Text, phoneTextBox.Text);

            p.updatePatient(p);
        }

        private DateTimePicker timePicker;

        private void scheduleDateTime_ValueChanged(object sender, EventArgs e)
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(850, 90);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            MedicalForm mf = new MedicalForm();
            mf.ShowDialog();
        }
    }
}
