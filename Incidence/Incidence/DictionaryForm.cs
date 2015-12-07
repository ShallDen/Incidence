using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incidence
{
    public partial class DictionaryForm : Form
    {
        public string mDictionarryText = string.Empty;

        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            dictionaryTextBox.Text = mDictionarryText;
        }
    }
}
