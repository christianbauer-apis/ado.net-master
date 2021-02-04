namespace Hospital
{
    partial class HomeForm
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
            this.Patientbutton = new System.Windows.Forms.Button();
            this.Doctorbutton = new System.Windows.Forms.Button();
            this.Staffbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Patientbutton
            // 
            this.Patientbutton.Location = new System.Drawing.Point(241, 103);
            this.Patientbutton.Name = "Patientbutton";
            this.Patientbutton.Size = new System.Drawing.Size(75, 23);
            this.Patientbutton.TabIndex = 0;
            this.Patientbutton.Text = "Patient";
            this.Patientbutton.UseVisualStyleBackColor = true;
            this.Patientbutton.Click += new System.EventHandler(this.Patientbutton_Click);
            // 
            // Doctorbutton
            // 
            this.Doctorbutton.Location = new System.Drawing.Point(241, 172);
            this.Doctorbutton.Name = "Doctorbutton";
            this.Doctorbutton.Size = new System.Drawing.Size(75, 23);
            this.Doctorbutton.TabIndex = 1;
            this.Doctorbutton.Text = "Doctor";
            this.Doctorbutton.UseVisualStyleBackColor = true;
            this.Doctorbutton.Click += new System.EventHandler(this.Doctorbutton_Click);
            // 
            // Staffbutton
            // 
            this.Staffbutton.Location = new System.Drawing.Point(241, 238);
            this.Staffbutton.Name = "Staffbutton";
            this.Staffbutton.Size = new System.Drawing.Size(75, 23);
            this.Staffbutton.TabIndex = 2;
            this.Staffbutton.Text = "Staff";
            this.Staffbutton.UseVisualStyleBackColor = true;
            this.Staffbutton.Click += new System.EventHandler(this.Staffbutton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 460);
            this.Controls.Add(this.Staffbutton);
            this.Controls.Add(this.Doctorbutton);
            this.Controls.Add(this.Patientbutton);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Patientbutton;
        private System.Windows.Forms.Button Doctorbutton;
        private System.Windows.Forms.Button Staffbutton;
    }
}