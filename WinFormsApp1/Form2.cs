using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public string fileName
        {
            get
            {
                return fileNameTxtBox.Text;
            }

            set
            {
                fileNameTxtBox.Text = value;
            }
        }

        public string lang1
        {
            get
            {
                return lang1TxtBox.Text;
            }

            set
            {
                lang1TxtBox.Text = value;
            }
        }

        public string lang2
        {
            get
            {
                return lang2TxtBox.Text;
            }

            set
            {
                lang2TxtBox.Text = value;
            }
        }

        public string lang3
        {
            get
            {
                return lang3TxtBox.Text;
            }

            set
            {
                lang3TxtBox.Text = value;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void lang2TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (lang2TxtBox.Text == string.Empty)
            {
                lang3TxtBox.Enabled = false;
            }
            else
            {
                lang3TxtBox.Enabled = true;
            }
        }
    }
}
