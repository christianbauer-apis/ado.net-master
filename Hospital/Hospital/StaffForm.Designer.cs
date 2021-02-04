namespace Hospital
{
    partial class StaffForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionButton = new System.Windows.Forms.Button();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.admitButton = new System.Windows.Forms.Button();
            this.dischargeButton = new System.Windows.Forms.Button();
            this.patientDate = new System.Windows.Forms.DateTimePicker();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.patientButton = new System.Windows.Forms.Button();
            this.prescriptionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "patient id:";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            // 
            // conditionButton
            // 
            this.conditionButton.Location = new System.Drawing.Point(46, 255);
            this.conditionButton.Name = "conditionButton";
            this.conditionButton.Size = new System.Drawing.Size(76, 51);
            this.conditionButton.TabIndex = 2;
            this.conditionButton.Text = "view conditions";
            this.conditionButton.UseVisualStyleBackColor = true;
            this.conditionButton.Click += new System.EventHandler(this.conditionButton_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Location = new System.Drawing.Point(54, 80);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(568, 150);
            this.staffDataGridView.TabIndex = 3;
            this.staffDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridView_CellContentClick);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Location = new System.Drawing.Point(375, 255);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(75, 51);
            this.scheduleButton.TabIndex = 4;
            this.scheduleButton.Text = "view doctor schedule";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // admitButton
            // 
            this.admitButton.Location = new System.Drawing.Point(742, 40);
            this.admitButton.Name = "admitButton";
            this.admitButton.Size = new System.Drawing.Size(75, 23);
            this.admitButton.TabIndex = 5;
            this.admitButton.Text = "admit patient";
            this.admitButton.UseVisualStyleBackColor = true;
            this.admitButton.Click += new System.EventHandler(this.admitButton_Click);
            // 
            // dischargeButton
            // 
            this.dischargeButton.Location = new System.Drawing.Point(832, 40);
            this.dischargeButton.Name = "dischargeButton";
            this.dischargeButton.Size = new System.Drawing.Size(75, 23);
            this.dischargeButton.TabIndex = 6;
            this.dischargeButton.Text = "discharge";
            this.dischargeButton.UseVisualStyleBackColor = true;
            this.dischargeButton.Click += new System.EventHandler(this.dischargeButton_Click);
            // 
            // patientDate
            // 
            this.patientDate.Location = new System.Drawing.Point(339, 43);
            this.patientDate.Name = "patientDate";
            this.patientDate.Size = new System.Drawing.Size(200, 20);
            this.patientDate.TabIndex = 7;
            this.patientDate.ValueChanged += new System.EventHandler(this.patientDate_ValueChanged);
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(140, 40);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientTextBox.TabIndex = 8;
            this.patientTextBox.TextChanged += new System.EventHandler(this.patientTextBox_TextChanged);
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(538, 255);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(84, 51);
            this.patientButton.TabIndex = 10;
            this.patientButton.Text = "Patient Information";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // prescriptionButton
            // 
            this.prescriptionButton.Location = new System.Drawing.Point(211, 255);
            this.prescriptionButton.Name = "prescriptionButton";
            this.prescriptionButton.Size = new System.Drawing.Size(75, 50);
            this.prescriptionButton.TabIndex = 11;
            this.prescriptionButton.Text = "view precriptions";
            this.prescriptionButton.UseVisualStyleBackColor = true;
            this.prescriptionButton.Click += new System.EventHandler(this.prescriptionButton_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 372);
            this.Controls.Add(this.prescriptionButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.patientTextBox);
            this.Controls.Add(this.patientDate);
            this.Controls.Add(this.dischargeButton);
            this.Controls.Add(this.admitButton);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.conditionButton);
            this.Controls.Add(this.label1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conditionButton;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button admitButton;
        private System.Windows.Forms.Button dischargeButton;
     
        private System.Windows.Forms.BindingSource patientBindingSource;
      
        private System.Windows.Forms.DateTimePicker patientDate;
        private System.Windows.Forms.TextBox patientTextBox;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button prescriptionButton;
    }
}