namespace StaffResources
{
    partial class DismissalForm
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
            this.lbQuestion = new System.Windows.Forms.Label();
            this.dtpDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDismissEmployee = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbQuestion.Location = new System.Drawing.Point(52, 42);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(60, 24);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "label1";
            // 
            // dtpDismissalDate
            // 
            this.dtpDismissalDate.Location = new System.Drawing.Point(56, 258);
            this.dtpDismissalDate.Name = "dtpDismissalDate";
            this.dtpDismissalDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDismissalDate.TabIndex = 1;
            this.dtpDismissalDate.Value = new System.DateTime(2021, 3, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz datę zwolnienia pracownika";
            // 
            // btnDismissEmployee
            // 
            this.btnDismissEmployee.Location = new System.Drawing.Point(229, 386);
            this.btnDismissEmployee.Name = "btnDismissEmployee";
            this.btnDismissEmployee.Size = new System.Drawing.Size(123, 23);
            this.btnDismissEmployee.TabIndex = 3;
            this.btnDismissEmployee.Text = "Zwolnij";
            this.btnDismissEmployee.UseVisualStyleBackColor = true;
            this.btnDismissEmployee.Click += new System.EventHandler(this.btnDismissEmployee_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Location = new System.Drawing.Point(53, 298);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(0, 13);
            this.lbInformation.TabIndex = 6;
            // 
            // DismissalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 454);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDismissEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDismissalDate);
            this.Controls.Add(this.lbQuestion);
            this.MaximumSize = new System.Drawing.Size(441, 493);
            this.MinimumSize = new System.Drawing.Size(441, 493);
            this.Name = "DismissalForm";
            this.Text = "Zwalnianie pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.DateTimePicker dtpDismissalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDismissEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbInformation;
    }
}