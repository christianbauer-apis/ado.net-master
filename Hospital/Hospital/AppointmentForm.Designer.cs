namespace Hospital
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.doctorGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.aIDTextBox = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorGridView
            // 
            this.doctorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorGridView.Location = new System.Drawing.Point(100, 35);
            this.doctorGridView.Name = "doctorGridView";
            this.doctorGridView.Size = new System.Drawing.Size(519, 61);
            this.doctorGridView.TabIndex = 0;
            this.doctorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctors:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DoctorID:";
            // 
            // dIDTextBox
            // 
            this.dIDTextBox.Location = new System.Drawing.Point(156, 119);
            this.dIDTextBox.Name = "dIDTextBox";
            this.dIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dIDTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PatientID:";
            // 
            // pIDTextBox
            // 
            this.pIDTextBox.Location = new System.Drawing.Point(157, 152);
            this.pIDTextBox.Name = "pIDTextBox";
            this.pIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pIDTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Appointment Date:";
            // 
            // appointmentDateTime
            // 
            this.appointmentDateTime.Location = new System.Drawing.Point(198, 175);
            this.appointmentDateTime.Name = "appointmentDateTime";
            this.appointmentDateTime.Size = new System.Drawing.Size(200, 20);
            this.appointmentDateTime.TabIndex = 7;
            this.appointmentDateTime.ValueChanged += new System.EventHandler(this.appointmentDateTime_ValueChanged);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Location = new System.Drawing.Point(460, 122);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(150, 30);
            this.scheduleButton.TabIndex = 8;
            this.scheduleButton.Text = "schedule appointment";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.AllowUserToAddRows = false;
            this.appointmentGridView.AllowUserToDeleteRows = false;
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGridView.Location = new System.Drawing.Point(100, 210);
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.ReadOnly = true;
            this.appointmentGridView.Size = new System.Drawing.Size(318, 74);
            this.appointmentGridView.TabIndex = 9;
            this.appointmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentGridView_CellContentClick);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "AppointmentID:";
            // 
            // aIDTextBox
            // 
            this.aIDTextBox.Location = new System.Drawing.Point(510, 237);
            this.aIDTextBox.Name = "aIDTextBox";
            this.aIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.aIDTextBox.TabIndex = 11;
            this.aIDTextBox.TextChanged += new System.EventHandler(this.aIDTextBox_TextChanged);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(100, 319);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(133, 23);
            this.viewButton.TabIndex = 12;
            this.viewButton.Text = "view appointments";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(479, 302);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 426);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.aIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appointmentGridView);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.appointmentDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorGridView);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker appointmentDateTime;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.DataGridView appointmentGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aIDTextBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button deleteButton;
        
        private System.Windows.Forms.BindingSource appointmentBindingSource;
  
    }
}