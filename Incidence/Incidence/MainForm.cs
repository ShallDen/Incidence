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
        string mDictionaryFileName = "..\\..\\Data\\Dictionary.txt";
        string mText = string.Empty;
        IncidenceModel model = new IncidenceModel();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            chooseDictionaryButton.Visible = false;
            ReadDictionary();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(ex.Message + "\nPlease choose dictionary file manually"), "Load failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, "Load failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ReadText()
        {
            try
            {
                StreamReader sr = new StreamReader(mFileName);
                inputDataTextBox.Text = sr.ReadToEnd();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(string.Format("Dictionary file is not founded. Please choose dictionary file manually.\n" + ex.Message), "Load failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void showDictionaryButton_Click(object sender, EventArgs e)
        {
            DictionaryForm dictionaryForm = new DictionaryForm();
            dictionaryForm.mDictionarryText = model.mDictionaryText;
            dictionaryForm.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputDataTextBox.Text = string.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            model.mText = inputDataTextBox.Text;
            model.Calculate();
            PrintMatrixToGrid(model.mIncedenceMatrix);
        }

        private void PrintMatrixToGrid(int[,] matrix)
        {
            incidenceGrid.RowCount = matrix.GetLength(0) + 1;
            incidenceGrid.ColumnCount = matrix.GetLength(1) + 1;

            //Show termins
            for (int i = 0; i < model.mTerminList.Count; i++)
            {
                incidenceGrid.Rows[i + 1].Cells[0].Value = model.mTerminList[i];
                incidenceGrid.Rows[0].Cells[i + 1].Value = model.mTerminList[i];
            }

            //Show values of matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    incidenceGrid.Rows[i + 1].Cells[j + 1].Value = matrix[i, j];
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(string.Format("C:\\Users\\" + Environment.UserName + "\\Desktop\\Output.txt")))
            {
                if (model.mTerminList.Count == 0)
                {
                    file.WriteLine("There are no termins.");
                    return;
                }

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