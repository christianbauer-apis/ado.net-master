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
    public partial class DoctorPortalForm : Form
    {
        public DoctorPortalForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DoctorInfoForm df = new DoctorInfoForm();
            df.ShowDialog();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            DoctorActionForm df = new DoctorActionForm();
            df.ShowDialog();
        }
    }
}
