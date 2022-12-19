namespace WinFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameTxtBox = new System.Windows.Forms.TextBox();
            this.lang1TxtBox = new System.Windows.Forms.TextBox();
            this.lang2TxtBox = new System.Windows.Forms.TextBox();
            this.lang3TxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New file name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Language 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Language 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Language 3";
            // 
            // fileNameTxtBox
            // 
            this.fileNameTxtBox.Location = new System.Drawing.Point(166, 41);
            this.fileNameTxtBox.Name = "fileNameTxtBox";
            this.fileNameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.fileNameTxtBox.TabIndex = 4;
            // 
            // lang1TxtBox
            // 
            this.lang1TxtBox.Location = new System.Drawing.Point(166, 119);
            this.lang1TxtBox.Name = "lang1TxtBox";
            this.lang1TxtBox.Size = new System.Drawing.Size(125, 27);
            this.lang1TxtBox.TabIndex = 5;
            // 
            // lang2TxtBox
            // 
            this.lang2TxtBox.Location = new System.Drawing.Point(166, 193);
            this.lang2TxtBox.Name = "lang2TxtBox";
            this.lang2TxtBox.Size = new System.Drawing.Size(125, 27);
            this.lang2TxtBox.TabIndex = 6;
            this.lang2TxtBox.TextChanged += new System.EventHandler(this.lang2TxtBox_TextChanged);
            // 
            // lang3TxtBox
            // 
            this.lang3TxtBox.Location = new System.Drawing.Point(166, 253);
            this.lang3TxtBox.Name = "lang3TxtBox";
            this.lang3TxtBox.Size = new System.Drawing.Size(125, 27);
            this.lang3TxtBox.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(305, 370);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 29);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 438);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lang3TxtBox);
            this.Controls.Add(this.lang2TxtBox);
            this.Controls.Add(this.lang1TxtBox);
            this.Controls.Add(this.fileNameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox fileNameTxtBox;
        private TextBox lang1TxtBox;
        private TextBox lang2TxtBox;
        private TextBox lang3TxtBox;
        private Button addBtn;
    }
}