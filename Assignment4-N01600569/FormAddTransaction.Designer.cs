namespace Assignment4_N01600569
{
    partial class FormAddTransaction
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
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            textBoxAddAmount = new TextBox();
            textBoxAddDes = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 121);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 210);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(178, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 48);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxAddAmount
            // 
            textBoxAddAmount.Location = new Point(178, 115);
            textBoxAddAmount.Name = "textBoxAddAmount";
            textBoxAddAmount.Size = new Size(342, 31);
            textBoxAddAmount.TabIndex = 5;
            // 
            // textBoxAddDes
            // 
            textBoxAddDes.Location = new Point(178, 204);
            textBoxAddDes.Name = "textBoxAddDes";
            textBoxAddDes.Size = new Size(342, 31);
            textBoxAddDes.TabIndex = 6;
            // 
            // FormAddTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 428);
            Controls.Add(textBoxAddDes);
            Controls.Add(textBoxAddAmount);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormAddTransaction";
            Text = "FormAddTransaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private TextBox textBoxAddAmount;
        private TextBox textBoxAddDes;
    }
}