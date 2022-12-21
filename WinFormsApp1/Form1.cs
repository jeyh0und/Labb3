using ClassLibrary;
using System.Text;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public WordList thisFile = null;
        public Word practice = null;
        string file = string.Empty;
        private int tries;
        private int rightAnsw;
        private float correctPerc;
        private int languageCount = 0;
        static string localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string pathFolder = Path.Combine(localAppDataFolder, "Labb3");
        public Form1()
        {
            InitializeComponent();
            FullList();
        }

        private void listFilesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFilesBox.SelectedItems.Count > 0)
            {
                viewListBtn.Enabled = true;
                practiceBtn.Enabled = true;
                string file = listFilesBox.Items[listFilesBox.SelectedIndex].ToString();
                thisFile = WordList.LoadList(file);
            }
        }

        private void FullList()
        {
            listFilesBox.Items.AddRange(WordList.GetLists());
        }

        private void ViewListBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            wordAddTextBox.Enabled = true;
            langLable.Visible = true;

            for (int i = 0; i < thisFile.Languages.Length; i++)
            {
                dataGridView1.Columns.Add(thisFile.Languages[i].ToString(), thisFile.Languages[i]);
            }

            thisFile.List(0, translations);
            langLable.Text = thisFile.Languages[0];

            void translations(string[] translations)
            {
                int row = dataGridView1.Rows.Add();
                for (int i = 0; i < thisFile.Languages.Length; i++)
                {
                    dataGridView1.Rows[row].Cells[thisFile.Languages[i]].Value = translations[i];
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string[] rows = addedWordTextBox.Text.Split(";", StringSplitOptions.RemoveEmptyEntries);
            languageCount = 0;
            langLable.Text = thisFile.Languages[0];

            if (rows.Length != thisFile.Languages.Length)
            {
                MessageBox.Show("You must type as many words as there are languages!");
                addedWordTextBox.Text = string.Empty;
            }
            else
            {
                dataGridView1.Rows.Add(rows);
                thisFile.Add(rows);
                thisFile.Save();

                MessageBox.Show("List has been saved", "File saved");
                addedWordTextBox.Text = string.Empty;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            string abc = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[thisFile.Languages[dataGridView1.SelectedCells[0].ColumnIndex]].FormattedValue.ToString();
            thisFile.Remove(0, abc);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                removeBtn.Enabled = true;
            }
            else
            {
                removeBtn.Enabled = false;
            }
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            languageCount++;

            if (languageCount == thisFile.Languages.Length)
            {
                languageCount = 0;
            }
            langLable.Text = thisFile.Languages[languageCount];
            addedWordTextBox.AppendText(wordAddTextBox.Text + ";");
            wordAddTextBox.Text = string.Empty;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            addedWordTextBox.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0, 1);
        }
        private void practiceBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            nxtBtn.Enabled = false;
            exitBtn.Enabled = false;
            toLanguageTxtBox.Text = string.Empty;

            BeginPractice();
        }

        private void nextWord()
        {
            toLanguageTxtBox.Text = String.Empty;
            exitBtn.Enabled = true;
            nxtBtn.Enabled = true;
            if (toLanguageTxtBox.Text == practice.Translations[practice.ToLanguage])
            {
                label2.Text = "Correct!";
                tries++;
                rightAnsw++;
            }
            else
            {
                label2.Text = "Wrong!";
                tries++;
            }
            BeginPractice();
        }
        private void toLanguageTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextWord();
            }
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            nextWord();
        }

        void BeginPractice()
        {
            practice = thisFile.GetWordToPractice();
            fromLanguageLabel.Text = $"From {thisFile.Languages[practice.FromLanguage]}";
            toLanguageLable.Text = $"To {thisFile.Languages[practice.ToLanguage]}";
            fromLanguageTxtBox.Text = practice.Translations[practice.FromLanguage];
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            correctPerc = rightAnsw / tries;
            MessageBox.Show($"{correctPerc * 100:f0}% of your answers were correct!", "Exit practice");
            tabControl1.SelectedIndex = 0;
        }

        private void newFileBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (form2.DialogResult == DialogResult.Yes)
            {
                if (form2.fileName == string.Empty || form2.lang1 == string.Empty || form2.lang2 == string.Empty)
                {
                    MessageBox.Show("Please enter file name and at least two languages", "Error");
                }
                else
                {
                    CreateANewFile(form2.fileName, form2.lang1, form2.lang2, form2.lang3);
                }
            }
            else
            {
                MessageBox.Show("No new file has been created", "Error");
            }
            listFilesBox.Items.Clear();
            listFilesBox.Items.AddRange(WordList.GetLists());
        }

        public void CreateANewFile(string name, params string[] langs)
        {
            string file = Path.Combine(pathFolder, name + ".dat");
            if (!File.Exists(file))
            {
                using (FileStream fs = File.Create(file))
                {
                    byte[] buffer = new UTF8Encoding(true).GetBytes($"{string.Join(";", langs)}");
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
        }

        private void wordAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (wordAddTextBox.Text != string.Empty)
            {
                listFilesBox.Enabled = false;
                addWordBtn.Enabled = true;
                langLable.Visible = true;
            }
        }

        private void addedWordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addedWordTextBox.Text != string.Empty)
            {
                listFilesBox.Enabled = false;
                clearBtn.Enabled = true;
                saveBtn.Enabled = true;
                label4.Visible = true;
            }
            else
            {
                saveBtn.Enabled = false;
                listFilesBox.Enabled = true;
                clearBtn.Enabled = false;
                label4.Visible = false;
            }
        }

        private void fromLanguageTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}