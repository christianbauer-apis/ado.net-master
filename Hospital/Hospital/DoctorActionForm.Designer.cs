namespace Hospital
{
    partial class DoctorActionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.admitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.prescribeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "patient ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(113, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Admit Date:";
            // 
            // admitDateTimePicker
            // 
            this.admitDateTimePicker.Location = new System.Drawing.Point(308, 32);
            this.admitDateTimePicker.Name = "admitDateTimePicker";
            this.admitDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.admitDateTimePicker.TabIndex = 27;
            this.admitDateTimePicker.ValueChanged += new System.EventHandler(this.admitDateTimePicker_ValueChanged);
            // 
            // admitButton
            // 
            this.admitButton.Location = new System.Drawing.Point(39, 78);
            this.admitButton.Name = "admitButton";
            this.admitButton.Size = new System.Drawing.Size(75, 23);
            this.admitButton.TabIndex = 4;
            this.admitButton.Text = "Admit";
            this.admitButton.UseVisualStyleBackColor = true;
            this.admitButton.Click += new System.EventHandler(this.admitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "prescription:";
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Location = new System.Drawing.Point(106, 144);
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.prescriptionTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "dosage:";
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.Location = new System.Drawing.Point(297, 144);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(100, 20);
            this.dosageTextBox.TabIndex = 23;
            // 
            // prescribeButton
            // 
            this.prescribeButton.Location = new System.Drawing.Point(106, 189);
            this.prescribeButton.Name = "prescribeButton";
            this.prescribeButton.Size = new System.Drawing.Size(75, 23);
            this.prescribeButton.TabIndex = 24;
            this.prescribeButton.Text = "Prescribe";
            this.prescribeButton.UseVisualStyleBackColor = true;
            this.prescribeButton.Click += new System.EventHandler(this.prescribeButton_Click);
            // 
            // DoctorActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 262);
            this.Controls.Add(this.prescribeButton);
            this.Controls.Add(this.admitDateTimePicker);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admitButton);
            this.Name = "DoctorActionForm";
            this.Text = "DoctorActionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker admitDateTimePicker;
        private System.Windows.Forms.Button admitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.Button prescribeButton;

    }
}