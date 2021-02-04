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
    public partial class StaffForm : Form
    {

        public StaffForm()
        {
            InitializeComponent();
        }

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            
        }

        private void admitButton_Click(object sender, EventArgs e)
        {
            try{

                if (patientTextBox.Text != "")
                {
                    Patient p = new Patient(patientTextBox.Text, patientDate.Value);

                    p.admitPatient(p);

                    MessageBox.Show("Update Success!");
                }
                else
                { MessageBox.Show("Please enter a id."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no matching id");
            }
        }

        private void dischargeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (patientTextBox.Text != "")
                {
                    Patient p = new Patient(patientTextBox.Text, patientDate.Value);

                    p.dischargePatient(p);

                    MessageBox.Show("Update Success!");
                }
                else
                { MessageBox.Show("Please enter a id."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no matching id");
            }
        }
        private DateTimePicker timePicker;
       

        private void patientDate_ValueChanged(object sender, EventArgs e)
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(550, 43);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }

       

        private void staffDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            staffDataGridView.DataSource = d.getDoctor();
        }

        private void patientTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.ShowDialog();
        }

        private void conditionButton_Click(object sender, EventArgs e)
        {
            try
            {
                Medical m = new Medical(patientTextBox.Text);
               
                staffDataGridView.DataSource = m.conditionView(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void prescriptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                Medical m = new Medical(patientTextBox.Text);
             
                staffDataGridView.DataSource = m.prescriptionView(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
