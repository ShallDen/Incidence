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
                    ReadDictionary();
                    inputDataTextBox.Text = model.mText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadText()
        {
            try
            {
                StreamReader sr = new StreamReader(mFileName);
                model.mText = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputDataTextBox.Text = string.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            model.Calculate();
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

        private void ReadDictionary()
        {
            try
            {
                StreamReader sr = new StreamReader(mDictionaryFileName);
                model.mDictionaryText = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
