namespace Sunshine
{
    partial class logisticGenerateDeliveryNote
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
            this.txtNoteID = new System.Windows.Forms.TextBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCustOrderID = new System.Windows.Forms.TextBox();
            this.txtSuppOrderID = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoteID
            // 
            this.txtNoteID.Location = new System.Drawing.Point(165, 82);
            this.txtNoteID.Name = "txtNoteID";
            this.txtNoteID.Size = new System.Drawing.Size(187, 22);
            this.txtNoteID.TabIndex = 0;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(515, 85);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDeliveryDate.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(165, 221);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(189, 22);
            this.txtItem.TabIndex = 2;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(515, 221);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(200, 22);
            this.nudQty.TabIndex = 3;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(165, 281);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(550, 67);
            this.txtLocation.TabIndex = 4;
            // 
            // txtCustOrderID
            // 
            this.txtCustOrderID.Location = new System.Drawing.Point(515, 147);
            this.txtCustOrderID.Name = "txtCustOrderID";
            this.txtCustOrderID.Size = new System.Drawing.Size(200, 22);
            this.txtCustOrderID.TabIndex = 5;
            // 
            // txtSuppOrderID
            // 
            this.txtSuppOrderID.Location = new System.Drawing.Point(165, 147);
            this.txtSuppOrderID.Name = "txtSuppOrderID";
            this.txtSuppOrderID.Size = new System.Drawing.Size(187, 22);
            this.txtSuppOrderID.TabIndex = 6;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInstruction.Location = new System.Drawing.Point(62, 30);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(235, 12);
            this.lblInstruction.TabIndex = 8;
            this.lblInstruction.Text = "Please fill up the following information :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Delivery Note ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delivery Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Deliver to:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Supply Order ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Customer Order ID:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGenerate.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenerate.Location = new System.Drawing.Point(281, 379);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(256, 23);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate Delivery Note";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // logisticGenerateDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtSuppOrderID);
            this.Controls.Add(this.txtCustOrderID);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.txtNoteID);
            this.Name = "logisticGenerateDeliveryNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Delivery Note";
            this.Load += new System.EventHandler(this.logisticGenerateDeliveryNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoteID;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtCustOrderID;
        private System.Windows.Forms.TextBox txtSuppOrderID;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerate;
    }
}