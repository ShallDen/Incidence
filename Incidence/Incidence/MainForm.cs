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
        int mColumnWidth = 70;
        IncidenceModel model = new IncidenceModel();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            chooseDictionaryButton.Visible = false;
            ReadDictionary();

            saveButton.Enabled = false;
            toolTip.SetToolTip(trackBar, "Scroll to change width of columns");
            trackBar.Enabled = false;
            trackBar.Value = mColumnWidth;
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
            var rowLength = matrix.GetLength(0);
            var columnLength = matrix.GetLength(0);

            if (rowLength < 1 || columnLength < 1)
            {
                MessageBox.Show("Matrix is empty. There no data to show.", "Show info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            incidenceGrid.RowCount = rowLength;
            incidenceGrid.ColumnCount = columnLength;

            //Show termins
            for (int i = 0; i < model.mTerminList.Count; i++)
            {
                incidenceGrid.Rows[i].HeaderCell.Value = model.mTerminList[i];
                incidenceGrid.Columns[i].HeaderCell.Value = model.mTerminList[i];

                incidenceGrid.Columns[i].Width = mColumnWidth;
            }

            //Show values of matrix
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    incidenceGrid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            saveButton.Enabled = true;
            trackBar.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(string.Format("C:\\Users\\" + Environment.UserName + "\\Desktop\\Output.txt")))
                {
                    if (model.mTerminList.Count == 0)
                    {
                        file.WriteLine("There are no termins.");
                        return;
                    }

                    file.WriteLine("Matrix:");
                    file.WriteLine("");

                    //Write top indexes
                    file.Write("     ");
                    for (int i = 0; i < model.mIncedenceMatrix.GetLength(1); i++)
                    {
                        if ((i + 1) < 10)
                            file.Write((i + 1) + " ");
                        else if ((i % 10 + 1) == 10)
                            file.Write(0 + " ");
                        else
                            file.Write((i % 10 + 1) + " ");
                    }

                    //Write top _
                    file.WriteLine(" ");
                    file.Write("    ");
                    for (int i = 0; i < model.mIncedenceMatrix.GetLength(1); i++)
                    {
                        file.Write("__");
                    }

                    //Write left indexes, | and matrix
                    file.WriteLine(" ");
                    for (int i = 0; i < model.mIncedenceMatrix.GetLength(1); i++)
                    {
                        if ((i + 1) < 10)
                            file.Write((i + 1) + ".  |");
                        else
                            file.Write((i + 1) + ". |");
                        for (int j = 0; j < model.mIncedenceMatrix.GetLength(0); j++)
                            file.Write(model.mIncedenceMatrix[i, j] + " ");
                        file.WriteLine(" ");
                    }

                    //Write termins
                    file.WriteLine(" ");
                    file.WriteLine(" ");
                    file.WriteLine("Termins:");
                    file.WriteLine(" ");
                    for (int i = 0; i < model.mTerminList.Count; i++)
                        file.WriteLine(string.Format((i + 1) + ". " + model.mTerminList[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            toolTip.SetToolTip(trackBar, trackBar.Value.ToString());

            try
            {
                for (int i = 0; i < model.mTerminList.Count; i++)
                {
                    incidenceGrid.Rows[i].HeaderCell.Value = model.mTerminList[i];
                    incidenceGrid.Columns[i].HeaderCell.Value = model.mTerminList[i];

                    incidenceGrid.Columns[i].Width = trackBar.Value;
                    mColumnWidth = trackBar.Value;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Scroll failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}