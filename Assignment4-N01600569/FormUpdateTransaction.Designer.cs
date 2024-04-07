namespace Assignment4_N01600569
{
    partial class FormUpdateTransaction
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxUDID = new TextBox();
            textBoxUDAccountID = new TextBox();
            textBoxUDDate = new TextBox();
            textBoxUDAmount = new TextBox();
            textBoxUDDes = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 51);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Transaction ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 332);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 251);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 2;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 180);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 3;
            label4.Text = "Transaction Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 114);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 4;
            label5.Text = "Account ID:";
            // 
            // textBoxUDID
            // 
            textBoxUDID.Location = new Point(214, 45);
            textBoxUDID.Name = "textBoxUDID";
            textBoxUDID.ReadOnly = true;
            textBoxUDID.Size = new Size(380, 31);
            textBoxUDID.TabIndex = 5;
            // 
            // textBoxUDAccountID
            // 
            textBoxUDAccountID.Location = new Point(214, 108);
            textBoxUDAccountID.Name = "textBoxUDAccountID";
            textBoxUDAccountID.ReadOnly = true;
            textBoxUDAccountID.Size = new Size(380, 31);
            textBoxUDAccountID.TabIndex = 6;
            // 
            // textBoxUDDate
            // 
            textBoxUDDate.Location = new Point(214, 174);
            textBoxUDDate.Name = "textBoxUDDate";
            textBoxUDDate.ReadOnly = true;
            textBoxUDDate.Size = new Size(380, 31);
            textBoxUDDate.TabIndex = 7;
            // 
            // textBoxUDAmount
            // 
            textBoxUDAmount.Location = new Point(214, 245);
            textBoxUDAmount.Name = "textBoxUDAmount";
            textBoxUDAmount.Size = new Size(380, 31);
            textBoxUDAmount.TabIndex = 8;
            // 
            // textBoxUDDes
            // 
            textBoxUDDes.Location = new Point(214, 326);
            textBoxUDDes.Name = "textBoxUDDes";
            textBoxUDDes.Size = new Size(380, 31);
            textBoxUDDes.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 403);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(191, 49);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormUpdateTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 489);
            Controls.Add(btnUpdate);
            Controls.Add(textBoxUDDes);
            Controls.Add(textBoxUDAmount);
            Controls.Add(textBoxUDDate);
            Controls.Add(textBoxUDAccountID);
            Controls.Add(textBoxUDID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUpdateTransaction";
            Text = "FormUpdateTransaction";
            Load += FormUpdateTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxUDID;
        private TextBox textBoxUDAccountID;
        private TextBox textBoxUDDate;
        private TextBox textBoxUDAmount;
        private TextBox textBoxUDDes;
        private Button btnUpdate;
    }
}