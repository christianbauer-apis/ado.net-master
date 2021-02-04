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
    public partial class DoctorActionForm : Form
    {
        public DoctorActionForm()
        {
            InitializeComponent();
        }

        private DateTimePicker timePicker;

        private void admitButton_Click(object sender, EventArgs e)
        {
            try{
                if (idTextBox.Text != "")
                {
                    Patient p = new Patient(idTextBox.Text, admitDateTimePicker.Value);
                    p.admitPatient(p);

                    MessageBox.Show("Update Success!");
                }
                else { MessageBox.Show("Please enter a id."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no matching id");
            }
        
        }

        private void prescribeButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                if (prescriptionTextBox.Text != "")
                {
                    if (dosageTextBox.Text != "")
                    {
                        Medical m = new Medical(Convert.ToInt32(idTextBox.Text), prescriptionTextBox.Text, dosageTextBox.Text);
                        m.addPrescription(m);
                    }
                    else { MessageBox.Show("Please enter a dosage."); }
                }
                else { MessageBox.Show("Please enter a prescription."); }
            }
            else { MessageBox.Show("Please enter a ID."); }
                    }

        private void admitDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(510, 32);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }
        

       
    }
}
