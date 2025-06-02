namespace Sunshine
{
    partial class LoginPage
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
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.forgetPasswordLL = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordPB = new System.Windows.Forms.PictureBox();
            this.usernamePB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sunshineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sunshineDataSet = new Sunshine.sunshineDataSet();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentTableAdapter = new Sunshine.sunshineDataSetTableAdapters.ComponentTableAdapter();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Sunshine.sunshineDataSetTableAdapters.StaffTableAdapter();
            this.sunshineDataSet1 = new Sunshine.sunshineDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(414, 317);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(412, 29);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(414, 228);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(272, 29);
            this.usernameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // forgetPasswordLL
            // 
            this.forgetPasswordLL.AutoSize = true;
            this.forgetPasswordLL.BackColor = System.Drawing.Color.Transparent;
            this.forgetPasswordLL.Location = new System.Drawing.Point(332, 378);
            this.forgetPasswordLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgetPasswordLL.Name = "forgetPasswordLL";
            this.forgetPasswordLL.Size = new System.Drawing.Size(151, 18);
            this.forgetPasswordLL.TabIndex = 3;
            this.forgetPasswordLL.TabStop = true;
            this.forgetPasswordLL.Text = "Forgotten Password?";
            this.forgetPasswordLL.Click += new System.EventHandler(this.forget_password_click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SpringGreen;
            this.loginButton.Location = new System.Drawing.Point(332, 421);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(496, 50);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordPB
            // 
            this.passwordPB.BackColor = System.Drawing.Color.Transparent;
            this.passwordPB.Image = global::Sunshine.Properties.Resources.lock_24dp;
            this.passwordPB.InitialImage = global::Sunshine.Properties.Resources.person_24dp;
            this.passwordPB.Location = new System.Drawing.Point(332, 317);
            this.passwordPB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordPB.Name = "passwordPB";
            this.passwordPB.Size = new System.Drawing.Size(24, 24);
            this.passwordPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordPB.TabIndex = 2;
            this.passwordPB.TabStop = false;
            // 
            // usernamePB
            // 
            this.usernamePB.BackColor = System.Drawing.Color.Transparent;
            this.usernamePB.Image = global::Sunshine.Properties.Resources.person_24dp;
            this.usernamePB.InitialImage = global::Sunshine.Properties.Resources.person_24dp;
            this.usernamePB.Location = new System.Drawing.Point(332, 228);
            this.usernamePB.Margin = new System.Windows.Forms.Padding(4);
            this.usernamePB.Name = "usernamePB";
            this.usernamePB.Size = new System.Drawing.Size(24, 24);
            this.usernamePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.usernamePB.TabIndex = 1;
            this.usernamePB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(685, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "@sunshine.com";
            // 
            // sunshineDataSetBindingSource
            // 
            this.sunshineDataSetBindingSource.DataSource = this.sunshineDataSet;
            this.sunshineDataSetBindingSource.Position = 0;
            // 
            // sunshineDataSet
            // 
            this.sunshineDataSet.DataSetName = "sunshineDataSet";
            this.sunshineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentBindingSource
            // 
            this.componentBindingSource.DataMember = "Component";
            this.componentBindingSource.DataSource = this.sunshineDataSetBindingSource;
            // 
            // componentTableAdapter
            // 
            this.componentTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.sunshineDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // sunshineDataSet1
            // 
            this.sunshineDataSet1.DataSetName = "sunshineDataSet";
            this.sunshineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoginPage
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.forgetPasswordLL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.passwordPB);
            this.Controls.Add(this.usernamePB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunshineDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox usernamePB;
        private System.Windows.Forms.PictureBox passwordPB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forgetPasswordLL;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sunshineDataSetBindingSource;
        private sunshineDataSet sunshineDataSet;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private sunshineDataSetTableAdapters.ComponentTableAdapter componentTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private sunshineDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private sunshineDataSet sunshineDataSet1;
    }
}

