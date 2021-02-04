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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }
       
        Doctor d = new Doctor();


        private void AppointmentForm_Load(object sender, EventArgs e)
        {
           
            doctorGridView.DataSource = d.showDoctors();

        }
       

        private DateTimePicker timePicker;
        private void appointmentDateTime_ValueChanged(object sender, EventArgs e)
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(400, 175);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }

       
        private void scheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment a = new Appointment(Convert.ToInt32(pIDTextBox.Text), Convert.ToInt32(dIDTextBox.Text), appointmentDateTime.Value);
                if (a.addAppointment(a) > 0)
                {
                    MessageBox.Show("Success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure both IDs are entered or that the IDs exist.");
            }
        }

        private void appointmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
             try
            {
                if (aIDTextBox.Text != "")
                {
            Appointment a = new Appointment(Convert.ToInt32(aIDTextBox.Text));

            appointmentGridView.DataSource = a.appointmentShow(a);
            }
                else { MessageBox.Show("Please enter a valid Appointment ID.", "Error"); }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void aIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (aIDTextBox.Text != "")
                {
                Appointment a = new Appointment(Convert.ToInt32(aIDTextBox.Text));


                a.deleteAppointment(a);

                MessageBox.Show("Success!");
                }
                else { MessageBox.Show("Please enter a valid Appointment ID.", "Error"); }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void doctorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
