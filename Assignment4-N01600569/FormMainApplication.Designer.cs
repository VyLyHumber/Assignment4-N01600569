namespace Assignment4_N01600569
{
    partial class FormMainApplication
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
            textBoxAccountID = new TextBox();
            textBoxCurrentBalance = new TextBox();
            textBoxAccountType = new TextBox();
            textBoxAccountDate = new TextBox();
            label5 = new Label();
            dataGridViewTransaction = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Account ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 82);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 1;
            label2.Text = "Account Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 183);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "Date Created:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 129);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 3;
            label4.Text = "Current Balance:";
            // 
            // textBoxAccountID
            // 
            textBoxAccountID.Location = new Point(167, 23);
            textBoxAccountID.Name = "textBoxAccountID";
            textBoxAccountID.Size = new Size(278, 31);
            textBoxAccountID.TabIndex = 4;
            // 
            // textBoxCurrentBalance
            // 
            textBoxCurrentBalance.Location = new Point(167, 123);
            textBoxCurrentBalance.Name = "textBoxCurrentBalance";
            textBoxCurrentBalance.Size = new Size(278, 31);
            textBoxCurrentBalance.TabIndex = 5;
            // 
            // textBoxAccountType
            // 
            textBoxAccountType.Location = new Point(167, 76);
            textBoxAccountType.Name = "textBoxAccountType";
            textBoxAccountType.Size = new Size(278, 31);
            textBoxAccountType.TabIndex = 6;
            // 
            // textBoxAccountDate
            // 
            textBoxAccountDate.Location = new Point(167, 177);
            textBoxAccountDate.Name = "textBoxAccountDate";
            textBoxAccountDate.Size = new Size(278, 31);
            textBoxAccountDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 253);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 9;
            label5.Text = "Transaction History:";
            // 
            // dataGridViewTransaction
            // 
            dataGridViewTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaction.Location = new Point(37, 306);
            dataGridViewTransaction.Name = "dataGridViewTransaction";
            dataGridViewTransaction.RowHeadersWidth = 62;
            dataGridViewTransaction.Size = new Size(806, 335);
            dataGridViewTransaction.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 680);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 52);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Transaction";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(333, 680);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(220, 52);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Transaction";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(623, 680);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(220, 52);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete Transaction";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormMainApplication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 756);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewTransaction);
            Controls.Add(label5);
            Controls.Add(textBoxAccountDate);
            Controls.Add(textBoxAccountType);
            Controls.Add(textBoxCurrentBalance);
            Controls.Add(textBoxAccountID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMainApplication";
            Text = "FormMainApplication";
            Load += FormMainApplication_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxAccountID;
        private TextBox textBoxCurrentBalance;
        private TextBox textBoxAccountType;
        private TextBox textBoxAccountDate;
        private Label label5;
        private DataGridView dataGridViewTransaction;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}