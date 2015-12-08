using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Incidence
{
    public partial class MainForm : Form
    {
        string mFileName = string.Empty;
        string mFileDir = string.Empty;
        string mDictionaryFileName = string.Empty;
        string mText = string.Empty;
        IncidenceModel model = new IncidenceModel();

        public MainForm()
        {
            InitializeComponent();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            bool isDictionaonaryAutoLoaded = false;
            try
            {
                openFileDialog.FileName = string.Empty;
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName == string.Empty)
                    {
                        return;
                    }

                    mFileName = openFileDialog.FileName;
                    mFileDir = mFileName.Replace(string.Format("\\" + openFileDialog.SafeFileName), "");
                    mDictionaryFileName = mFileDir + "\\Dictionary.txt";
                    inputDataTextBox.ScrollBars = ScrollBars.Both;

                    ReadText();
                    isDictionaonaryAutoLoaded = ReadDictionary();

                    if (isDictionaonaryAutoLoaded)
                        chooseDictionaryButton.Visible = false;
                    else
                        chooseDictionaryButton.Visible = true;

                    inputDataTextBox.Text = model.mText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(ex.Message + "\nPlease choose dictionary file manually"));
            }
        }

        private void chooseDictionaryButton_Click(object sender, EventArgs e)
        {
            bool isDictionaonaryLoaded = false;

            try
            {
                openFileDialog.FileName = string.Empty;
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName == string.Empty)
                    {
                        return;
                    }

                    mDictionaryFileName = openFileDialog.FileName;

                    isDictionaonaryLoaded = ReadDictionary();

                    if (isDictionaonaryLoaded)
                        chooseDictionaryButton.Visible = false;
                    else
                        chooseDictionaryButton.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ReadText()
        {
            try
            {
                StreamReader sr = new StreamReader(mFileName);
                model.mText = sr.ReadToEnd();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ReadDictionary()
        {
            try
            {
                StreamReader sr = new StreamReader(mDictionaryFileName);
                model.mDictionaryText = sr.ReadToEnd();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputDataTextBox.Text = string.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            model.Calculate();
            incidenceGrid.AutoGenerateColumns = true;

            inputDataTextBox.Text = "TEXT:\r\n";
            inputDataTextBox.Text += "************************\r\n";
            inputDataTextBox.Text += model.mClearedText;
            inputDataTextBox.Text += "\r\n\r\nDICTIONARY:\r\n";
            inputDataTextBox.Text += "************************\r\n";
            inputDataTextBox.Text += model.mClearedDictionaryText;

            inputDataTextBox.Text += "\r\n\r\nTERMINS:\r\n";
            inputDataTextBox.Text += "************************";

            foreach (var word in model.mTerminList)
            {
                inputDataTextBox.Text += "\r\n";
                inputDataTextBox.Text += word;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chooseDictionaryButton.Visible = false;
        }

        private void showDictionaryButton_Click(object sender, EventArgs e)
        {
            DictionaryForm dictionaryForm = new DictionaryForm();
            dictionaryForm.mDictionarryText = model.mDictionaryText;
            dictionaryForm.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\ShallDen\Desktop\Output.txt"))
            {
                for (int i = 0; i < model.mIncedenceMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < model.mIncedenceMatrix.GetLength(0); j++)
                        file.Write(model.mIncedenceMatrix[i, j] + " ");
                    file.WriteLine(" ");
                }
            }
        }
    }
}