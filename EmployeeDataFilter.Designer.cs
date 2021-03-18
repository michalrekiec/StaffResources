namespace StaffResources
{
    partial class EmployeeDataFilter
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
            this.cbManagement = new System.Windows.Forms.CheckBox();
            this.cbHR = new System.Windows.Forms.CheckBox();
            this.cbAccountancy = new System.Windows.Forms.CheckBox();
            this.cbIT = new System.Windows.Forms.CheckBox();
            this.gbDepartments = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLowerLimit = new System.Windows.Forms.TextBox();
            this.tbUpperLimit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbEmployed = new System.Windows.Forms.RadioButton();
            this.rbNotEmployed = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.gbDepartments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbManagement
            // 
            this.cbManagement.AutoSize = true;
            this.cbManagement.Checked = true;
            this.cbManagement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbManagement.Location = new System.Drawing.Point(30, 22);
            this.cbManagement.Name = "cbManagement";
            this.cbManagement.Size = new System.Drawing.Size(59, 17);
            this.cbManagement.TabIndex = 0;
            this.cbManagement.Text = "Zarząd";
            this.cbManagement.UseVisualStyleBackColor = true;
            // 
            // cbHR
            // 
            this.cbHR.AutoSize = true;
            this.cbHR.Checked = true;
            this.cbHR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHR.Location = new System.Drawing.Point(30, 45);
            this.cbHR.Name = "cbHR";
            this.cbHR.Size = new System.Drawing.Size(53, 17);
            this.cbHR.TabIndex = 1;
            this.cbHR.Text = "Kadry";
            this.cbHR.UseVisualStyleBackColor = true;
            // 
            // cbAccountancy
            // 
            this.cbAccountancy.AutoSize = true;
            this.cbAccountancy.Checked = true;
            this.cbAccountancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAccountancy.Location = new System.Drawing.Point(30, 68);
            this.cbAccountancy.Name = "cbAccountancy";
            this.cbAccountancy.Size = new System.Drawing.Size(83, 17);
            this.cbAccountancy.TabIndex = 2;
            this.cbAccountancy.Text = "Księgowość";
            this.cbAccountancy.UseVisualStyleBackColor = true;
            // 
            // cbIT
            // 
            this.cbIT.AutoSize = true;
            this.cbIT.Checked = true;
            this.cbIT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIT.Location = new System.Drawing.Point(30, 91);
            this.cbIT.Name = "cbIT";
            this.cbIT.Size = new System.Drawing.Size(36, 17);
            this.cbIT.TabIndex = 3;
            this.cbIT.Text = "IT";
            this.cbIT.UseVisualStyleBackColor = true;
            // 
            // gbDepartments
            // 
            this.gbDepartments.Controls.Add(this.cbIT);
            this.gbDepartments.Controls.Add(this.cbAccountancy);
            this.gbDepartments.Controls.Add(this.cbHR);
            this.gbDepartments.Controls.Add(this.cbManagement);
            this.gbDepartments.Location = new System.Drawing.Point(81, 78);
            this.gbDepartments.Name = "gbDepartments";
            this.gbDepartments.Size = new System.Drawing.Size(154, 130);
            this.gbDepartments.TabIndex = 4;
            this.gbDepartments.TabStop = false;
            this.gbDepartments.Text = "Wybierz dział(y)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUpperLimit);
            this.groupBox1.Controls.Add(this.tbLowerLimit);
            this.groupBox1.Location = new System.Drawing.Point(81, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz przedział zarobków";
            // 
            // tbLowerLimit
            // 
            this.tbLowerLimit.Location = new System.Drawing.Point(30, 32);
            this.tbLowerLimit.Name = "tbLowerLimit";
            this.tbLowerLimit.Size = new System.Drawing.Size(100, 20);
            this.tbLowerLimit.TabIndex = 0;
            // 
            // tbUpperLimit
            // 
            this.tbUpperLimit.Location = new System.Drawing.Point(179, 32);
            this.tbUpperLimit.Name = "tbUpperLimit";
            this.tbUpperLimit.Size = new System.Drawing.Size(100, 20);
            this.tbUpperLimit.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNotEmployed);
            this.groupBox2.Controls.Add(this.rbEmployed);
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Location = new System.Drawing.Point(260, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status zatrudnienia";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(28, 22);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(67, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Wszyscy";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbEmployed
            // 
            this.rbEmployed.AutoSize = true;
            this.rbEmployed.Location = new System.Drawing.Point(28, 45);
            this.rbEmployed.Name = "rbEmployed";
            this.rbEmployed.Size = new System.Drawing.Size(113, 17);
            this.rbEmployed.TabIndex = 1;
            this.rbEmployed.Text = "Pracujący obecnie";
            this.rbEmployed.UseVisualStyleBackColor = true;
            // 
            // rbNotEmployed
            // 
            this.rbNotEmployed.AutoSize = true;
            this.rbNotEmployed.Location = new System.Drawing.Point(28, 68);
            this.rbNotEmployed.Name = "rbNotEmployed";
            this.rbNotEmployed.Size = new System.Drawing.Size(139, 17);
            this.rbNotEmployed.TabIndex = 2;
            this.rbNotEmployed.Text = "Pracujący w przeszłości";
            this.rbNotEmployed.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(81, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(288, 372);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(130, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filtruj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(108, 321);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 9;
            // 
            // EmployeeDataFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 454);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDepartments);
            this.Name = "EmployeeDataFilter";
            this.Text = "EmployeeDataFilter";
            this.gbDepartments.ResumeLayout(false);
            this.gbDepartments.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbManagement;
        private System.Windows.Forms.CheckBox cbHR;
        private System.Windows.Forms.CheckBox cbAccountancy;
        private System.Windows.Forms.CheckBox cbIT;
        private System.Windows.Forms.GroupBox gbDepartments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbUpperLimit;
        private System.Windows.Forms.TextBox tbLowerLimit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNotEmployed;
        private System.Windows.Forms.RadioButton rbEmployed;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbError;
    }
}