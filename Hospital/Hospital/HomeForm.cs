//Author: Christian Bauer
//Summary: A small hospital database system.



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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Patientbutton_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.ShowDialog();
        }

        private void Doctorbutton_Click(object sender, EventArgs e)
        {
            DoctorPortalForm df = new DoctorPortalForm();
            df.ShowDialog();
        }

        private void Staffbutton_Click(object sender, EventArgs e)
        {
            StaffForm sf = new StaffForm();
            sf.ShowDialog();
        }

    }
}
