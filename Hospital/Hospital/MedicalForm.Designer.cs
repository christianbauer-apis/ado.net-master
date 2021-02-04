namespace Hospital
{
    partial class MedicalForm
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
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.cRemoveButton = new System.Windows.Forms.Button();
            this.cAddButton = new System.Windows.Forms.Button();
            this.pRemoveButton = new System.Windows.Forms.Button();
            this.pAddButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prescriptionListBox = new System.Windows.Forms.ListBox();
            this.conditionListBox = new System.Windows.Forms.ListBox();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(79, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Location = new System.Drawing.Point(457, 76);
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.prescriptionTextBox.TabIndex = 3;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(79, 73);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.conditionTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prescriptions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Patient ID:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 73);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Conditions:";
            // 
            // cRemoveButton
            // 
            this.cRemoveButton.Location = new System.Drawing.Point(122, 111);
            this.cRemoveButton.Name = "cRemoveButton";
            this.cRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.cRemoveButton.TabIndex = 8;
            this.cRemoveButton.Text = "Remove";
            this.cRemoveButton.UseVisualStyleBackColor = true;
            this.cRemoveButton.Click += new System.EventHandler(this.cRemoveButton_Click);
            // 
            // cAddButton
            // 
            this.cAddButton.Location = new System.Drawing.Point(15, 111);
            this.cAddButton.Name = "cAddButton";
            this.cAddButton.Size = new System.Drawing.Size(75, 23);
            this.cAddButton.TabIndex = 9;
            this.cAddButton.Text = "Add";
            this.cAddButton.UseVisualStyleBackColor = true;
            this.cAddButton.Click += new System.EventHandler(this.cAddButton_Click);
            // 
            // pRemoveButton
            // 
            this.pRemoveButton.Location = new System.Drawing.Point(610, 124);
            this.pRemoveButton.Name = "pRemoveButton";
            this.pRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.pRemoveButton.TabIndex = 10;
            this.pRemoveButton.Text = "Remove";
            this.pRemoveButton.UseVisualStyleBackColor = true;
            this.pRemoveButton.Click += new System.EventHandler(this.pRemoveButton_Click);
            // 
            // pAddButton
            // 
            this.pAddButton.Location = new System.Drawing.Point(457, 124);
            this.pAddButton.Name = "pAddButton";
            this.pAddButton.Size = new System.Drawing.Size(75, 23);
            this.pAddButton.TabIndex = 11;
            this.pAddButton.Text = "Add";
            this.pAddButton.UseVisualStyleBackColor = true;
            this.pAddButton.Click += new System.EventHandler(this.pAddButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(278, 302);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prescriptionListBox
            // 
            this.prescriptionListBox.FormattingEnabled = true;
            this.prescriptionListBox.Location = new System.Drawing.Point(515, 166);
            this.prescriptionListBox.Name = "prescriptionListBox";
            this.prescriptionListBox.Size = new System.Drawing.Size(120, 95);
            this.prescriptionListBox.TabIndex = 13;
            // 
            // conditionListBox
            // 
            this.conditionListBox.FormattingEnabled = true;
            this.conditionListBox.Location = new System.Drawing.Point(15, 166);
            this.conditionListBox.Name = "conditionListBox";
            this.conditionListBox.Size = new System.Drawing.Size(120, 95);
            this.conditionListBox.TabIndex = 14;
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.Location = new System.Drawing.Point(695, 76);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(100, 20);
            this.dosageTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dosage:";
            // 
            // MedicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 398);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(this.conditionListBox);
            this.Controls.Add(this.prescriptionListBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.pAddButton);
            this.Controls.Add(this.pRemoveButton);
            this.Controls.Add(this.cAddButton);
            this.Controls.Add(this.cRemoveButton);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "MedicalForm";
            this.Text = "MedicalForm";
            this.Load += new System.EventHandler(this.MedicalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.BindingSource patientBindingSource;
   
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button cRemoveButton;
        private System.Windows.Forms.Button cAddButton;
        private System.Windows.Forms.Button pRemoveButton;
        private System.Windows.Forms.Button pAddButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ListBox prescriptionListBox;
        private System.Windows.Forms.ListBox conditionListBox;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.Label label6;
    }
}