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
                    inputDataTextBox.ScrollBars = ScrollBars.Both;

                    ReadFromFile();
                    inputDataTextBox.Text = model.mText;
                }
            }
            catch { }
        }

        private void ReadFromFile()
        {
            StreamReader sr = new StreamReader(mFileName);
            model.mText = sr.ReadToEnd();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputDataTextBox.Text = string.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            model.Calculate();
        }
    }
}
