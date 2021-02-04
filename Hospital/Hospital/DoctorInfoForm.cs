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
    public partial class DoctorInfoForm : Form
    {
        public DoctorInfoForm()
        {
            InitializeComponent();
        }

      
        private DateTimePicker timePicker;
       

        private void startDateTime_ValueChanged(object sender, EventArgs e)
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(350, 97);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }

        private void endDateTime_ValueChanged(object sender, EventArgs e)
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(350, 123);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }

        private void availabilityButton_Click(object sender, EventArgs e)
        {
            try
            {
            if (idTextBox.Text != "")
                {
                Doctor d = new Doctor(Convert.ToInt32(idTextBox.Text), startDateTime.Value, endDateTime.Value);
                d.updateDoctorAvailability(d);
                MessageBox.Show("Update Success!");
                }
            else { MessageBox.Show("Please enter a id."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void contactButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (idTextBox.Text != "")
                {
                    if (nameTextBox.Text != "")
                    {
                        if (phoneTextBox.Text != "")
                        {
                            if (titleTextBox.Text != "")
                            {
                                if (addressTextBox.Text != "")
                                {

                                    Doctor d = new Doctor(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, phoneTextBox.Text, titleTextBox.Text, addressTextBox.Text);
                                    d.updateDoctor(d);
                                    MessageBox.Show("Update Success!");

                                }
                                else { MessageBox.Show("Please enter a address."); }
                            }
                            else { MessageBox.Show("Please enter an expertise."); }
                        }
                        else { MessageBox.Show("Please enter a phone number."); }
                    }
                    else { MessageBox.Show("Please enter an name."); }
                }
                else { MessageBox.Show("Please enter a id."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


 
    }
}
