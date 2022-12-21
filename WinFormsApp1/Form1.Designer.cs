namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.langLable = new System.Windows.Forms.Label();
            this.addedWordTextBox = new System.Windows.Forms.TextBox();
            this.wordAddTextBox = new System.Windows.Forms.TextBox();
            this.newFileBtn = new System.Windows.Forms.Button();
            this.practiceBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.viewListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listFilesBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fromLanguageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toLanguageLable = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.toLanguageTxtBox = new System.Windows.Forms.TextBox();
            this.fromLanguageTxtBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addWordBtn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.langLable);
            this.tabPage1.Controls.Add(this.addedWordTextBox);
            this.tabPage1.Controls.Add(this.wordAddTextBox);
            this.tabPage1.Controls.Add(this.newFileBtn);
            this.tabPage1.Controls.Add(this.practiceBtn);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.saveBtn);
            this.tabPage1.Controls.Add(this.removeBtn);
            this.tabPage1.Controls.Add(this.viewListBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listFilesBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addWordBtn
            // 
            this.addWordBtn.Location = new System.Drawing.Point(178, 407);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(94, 29);
            this.addWordBtn.TabIndex = 13;
            this.addWordBtn.Text = "Add Word";
            this.addWordBtn.UseVisualStyleBackColor = true;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add this";
            // 
            // langLable
            // 
            this.langLable.AutoSize = true;
            this.langLable.Location = new System.Drawing.Point(84, 363);
            this.langLable.Name = "langLable";
            this.langLable.Size = new System.Drawing.Size(74, 20);
            this.langLable.TabIndex = 11;
            this.langLable.Text = "Language";
            // 
            // addedWordTextBox
            // 
            this.addedWordTextBox.Location = new System.Drawing.Point(278, 386);
            this.addedWordTextBox.Name = "addedWordTextBox";
            this.addedWordTextBox.Size = new System.Drawing.Size(125, 27);
            this.addedWordTextBox.TabIndex = 10;
            this.addedWordTextBox.TextChanged += new System.EventHandler(this.addedWordTextBox_TextChanged);
            // 
            // wordAddTextBox
            // 
            this.wordAddTextBox.Location = new System.Drawing.Point(47, 386);
            this.wordAddTextBox.Name = "wordAddTextBox";
            this.wordAddTextBox.Size = new System.Drawing.Size(125, 27);
            this.wordAddTextBox.TabIndex = 9;
            this.wordAddTextBox.TextChanged += new System.EventHandler(this.wordAddTextBox_TextChanged);
            // 
            // newFileBtn
            // 
            this.newFileBtn.Location = new System.Drawing.Point(883, 306);
            this.newFileBtn.Name = "newFileBtn";
            this.newFileBtn.Size = new System.Drawing.Size(94, 29);
            this.newFileBtn.TabIndex = 8;
            this.newFileBtn.Text = "New file";
            this.newFileBtn.UseVisualStyleBackColor = true;
            this.newFileBtn.Click += new System.EventHandler(this.newFileBtn_Click);
            // 
            // practiceBtn
            // 
            this.practiceBtn.Location = new System.Drawing.Point(726, 306);
            this.practiceBtn.Name = "practiceBtn";
            this.practiceBtn.Size = new System.Drawing.Size(94, 29);
            this.practiceBtn.TabIndex = 7;
            this.practiceBtn.Text = "Practice";
            this.practiceBtn.UseVisualStyleBackColor = true;
            this.practiceBtn.Click += new System.EventHandler(this.practiceBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(593, 306);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear all";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(883, 252);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 29);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(726, 251);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(94, 29);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove Word";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // viewListBtn
            // 
            this.viewListBtn.BackColor = System.Drawing.Color.Peru;
            this.viewListBtn.Enabled = false;
            this.viewListBtn.Location = new System.Drawing.Point(593, 251);
            this.viewListBtn.Name = "viewListBtn";
            this.viewListBtn.Size = new System.Drawing.Size(94, 29);
            this.viewListBtn.TabIndex = 5;
            this.viewListBtn.Text = "View List";
            this.viewListBtn.UseVisualStyleBackColor = true;
            this.viewListBtn.Click += new System.EventHandler(this.ViewListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text Files";
            // 
            // listFilesBox
            // 
            this.listFilesBox.FormattingEnabled = true;
            this.listFilesBox.ItemHeight = 20;
            this.listFilesBox.Location = new System.Drawing.Point(604, 44);
            this.listFilesBox.Name = "listFilesBox";
            this.listFilesBox.Size = new System.Drawing.Size(362, 184);
            this.listFilesBox.TabIndex = 1;
            this.listFilesBox.SelectedIndexChanged += new System.EventHandler(this.listFilesBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 331);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fromLanguageLabel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.toLanguageLable);
            this.tabPage2.Controls.Add(this.exitBtn);
            this.tabPage2.Controls.Add(this.nxtBtn);
            this.tabPage2.Controls.Add(this.toLanguageTxtBox);
            this.tabPage2.Controls.Add(this.fromLanguageTxtBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fromLanguageLabel
            // 
            this.fromLanguageLabel.AutoSize = true;
            this.fromLanguageLabel.Location = new System.Drawing.Point(278, 71);
            this.fromLanguageLabel.Name = "fromLanguageLabel";
            this.fromLanguageLabel.Size = new System.Drawing.Size(43, 20);
            this.fromLanguageLabel.TabIndex = 7;
            this.fromLanguageLabel.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome to Practice Mode!";
            // 
            // toLanguageLable
            // 
            this.toLanguageLable.AutoSize = true;
            this.toLanguageLable.Location = new System.Drawing.Point(619, 71);
            this.toLanguageLable.Name = "toLanguageLable";
            this.toLanguageLable.Size = new System.Drawing.Size(25, 20);
            this.toLanguageLable.TabIndex = 5;
            this.toLanguageLable.Text = "To";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(221, 328);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 29);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // nxtBtn
            // 
            this.nxtBtn.Location = new System.Drawing.Point(593, 328);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(94, 29);
            this.nxtBtn.TabIndex = 3;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // toLanguageTxtBox
            // 
            this.toLanguageTxtBox.Location = new System.Drawing.Point(562, 118);
            this.toLanguageTxtBox.Name = "toLanguageTxtBox";
            this.toLanguageTxtBox.Size = new System.Drawing.Size(125, 27);
            this.toLanguageTxtBox.TabIndex = 1;
            this.toLanguageTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toLanguageTxtBox_KeyDown);
            // 
            // fromLanguageTxtBox
            // 
            this.fromLanguageTxtBox.Enabled = false;
            this.fromLanguageTxtBox.Location = new System.Drawing.Point(221, 118);
            this.fromLanguageTxtBox.Name = "fromLanguageTxtBox";
            this.fromLanguageTxtBox.Size = new System.Drawing.Size(125, 27);
            this.fromLanguageTxtBox.TabIndex = 0;
            this.fromLanguageTxtBox.TextChanged += new System.EventHandler(this.fromLanguageTxtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private ListBox listFilesBox;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button addWordBtn;
        private Label label4;
        private Label langLable;
        private TextBox addedWordTextBox;
        private TextBox wordAddTextBox;
        private Button newFileBtn;
        private Button practiceBtn;
        private Button clearBtn;
        private Button saveBtn;
        private Button removeBtn;
        private Button viewListBtn;
        private Label label2;
        private Label toLanguageLable;
        private Button exitBtn;
        private Button nxtBtn;
        private TextBox toLanguageTxtBox;
        private TextBox fromLanguageTxtBox;
        private Label fromLanguageLabel;
    }
}