namespace Sunshine.Manager_dept
{
    partial class EditEmployee
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(491, 430);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 51);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(643, 430);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 51);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(160, 265);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(531, 142);
            this.rtbComment.TabIndex = 55;
            this.rtbComment.Text = "";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(94, 266);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(60, 15);
            this.lblComment.TabIndex = 54;
            this.lblComment.Text = "Comment:";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(160, 207);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(73, 22);
            this.txtSalary.TabIndex = 53;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(111, 210);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(43, 15);
            this.lblSalary.TabIndex = 52;
            this.lblSalary.Text = "Salary:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(474, 47);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(37, 19);
            this.rbMale.TabIndex = 51;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "M";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(436, 47);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(32, 19);
            this.rbFemale.TabIndex = 50;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "F";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(382, 48);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "Gender:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(436, 153);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(255, 22);
            this.txtJobTitle.TabIndex = 48;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(374, 156);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(56, 15);
            this.lblJobTitle.TabIndex = 47;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpEmail.Location = new System.Drawing.Point(436, 93);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(255, 22);
            this.txtEmpEmail.TabIndex = 46;
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(392, 96);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmpEmail.TabIndex = 45;
            this.lblEmpEmail.Text = "Email:";
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptID.Location = new System.Drawing.Point(66, 155);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(88, 15);
            this.lblDeptID.TabIndex = 44;
            this.lblDeptID.Text = "Department ID:";
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(160, 152);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(73, 23);
            this.cmbDept.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 42;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(76, 100);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(78, 15);
            this.lblEmpID.TabIndex = 41;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(160, 48);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(151, 22);
            this.txtEmpName.TabIndex = 40;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(59, 51);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(95, 15);
            this.lblEmpName.TabIndex = 39;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.lblEmpEmail);
            this.Controls.Add(this.lblDeptID);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpName;
    }
}