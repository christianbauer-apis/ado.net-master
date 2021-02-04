using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Hospital
{
    public partial class MedicalForm : Form
    {
        public MedicalForm()
        {
            InitializeComponent();
        }

             
        private void MedicalForm_Load(object sender, EventArgs e)
        {

          //  Patient p = new Patient();
       //     MessageBox.Show(p.getPID());
        }

        private void cAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextBox.Text != "")
                {
                    if (conditionTextBox.Text != "")
                    {
                        conditionListBox.Items.Add(conditionTextBox.Text);
                        Medical m = new Medical(Convert.ToInt32(idTextBox.Text), conditionTextBox.Text);
                        m.addCondition(m);
                    }
                    else { MessageBox.Show("Please enter condition."); }
                }

                else { MessageBox.Show("Please enter ID."); }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void cRemoveButton_Click(object sender, EventArgs e)
        {

             try
            {
                if (idTextBox.Text != "")
                {
                     if (conditionTextBox.Text != "")
                    {
            conditionListBox.Items.Remove(conditionListBox.SelectedItem);
            Medical m = new Medical(Convert.ToInt32(idTextBox.Text), conditionTextBox.Text);
            m.deleteCondition(m);

                    }
                     else { MessageBox.Show("Please enter condition."); }
                     }

                  
                else { MessageBox.Show("Please enter ID."); }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pAddButton_Click(object sender, EventArgs e)
        {
             try
            {
                if (idTextBox.Text != "")
                {
                    if (prescriptionTextBox.Text != "")
                    {
                         if (dosageTextBox.Text != "")
                    {
                        prescriptionListBox.Items.Add(prescriptionTextBox.Text);
                        Medical m = new Medical(Convert.ToInt32(idTextBox.Text), prescriptionTextBox.Text, dosageTextBox.Text);
                        m.addPrescription(m);
                   
                          }
                else { MessageBox.Show("Please enter dosage."); }
                         }


                    else { MessageBox.Show("Please enter prescription."); }
                }

                else { MessageBox.Show("Please enter ID."); }
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pRemoveButton_Click(object sender, EventArgs e)
        {
             try
            {
                if (idTextBox.Text != "")
                {
                     if (prescriptionTextBox.Text != "")
                    {
                          if (dosageTextBox.Text != "")
                    {
            prescriptionListBox.Items.Remove(prescriptionListBox.SelectedItem);
            Medical m = new Medical(Convert.ToInt32(idTextBox.Text), prescriptionTextBox.Text, dosageTextBox.Text);
            m.deletePrescription(m);
                    }
                          else { MessageBox.Show("Please enter dosage."); }
                          }
                     else { MessageBox.Show("Please enter prescription."); }
                 }
                else { MessageBox.Show("Please enter ID."); }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            AppointmentForm af = new AppointmentForm();
            af.ShowDialog();
        }

       

       

        

       
       
    }
}
