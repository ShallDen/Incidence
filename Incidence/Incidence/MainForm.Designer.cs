namespace Incidence
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputDataTextBox = new System.Windows.Forms.TextBox();
            this.inputTextLabelLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.incidenceGrid = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.incidenceLabel = new System.Windows.Forms.Label();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseDictionaryButton = new System.Windows.Forms.Button();
            this.showDictionaryButton = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.incidenceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDataTextBox
            // 
            this.inputDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputDataTextBox.Location = new System.Drawing.Point(13, 35);
            this.inputDataTextBox.Multiline = true;
            this.inputDataTextBox.Name = "inputDataTextBox";
            this.inputDataTextBox.Size = new System.Drawing.Size(337, 288);
            this.inputDataTextBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.inputDataTextBox, "Text");
            // 
            // inputTextLabelLabel
            // 
            this.inputTextLabelLabel.AutoSize = true;
            this.inputTextLabelLabel.Location = new System.Drawing.Point(13, 13);
            this.inputTextLabelLabel.Name = "inputTextLabelLabel";
            this.inputTextLabelLabel.Size = new System.Drawing.Size(88, 13);
            this.inputTextLabelLabel.TabIndex = 1;
            this.inputTextLabelLabel.Text = "Please input text:";
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateButton.Location = new System.Drawing.Point(366, 338);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 36);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.toolTip.SetToolTip(this.calculateButton, "Click to calculate matrix");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(275, 338);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 36);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.toolTip.SetToolTip(this.clearButton, "Click to clear textbox");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // incidenceGrid
            // 
            this.incidenceGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incidenceGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.incidenceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidenceGrid.Location = new System.Drawing.Point(366, 35);
            this.incidenceGrid.Name = "incidenceGrid";
            this.incidenceGrid.RowHeadersWidth = 150;
            this.incidenceGrid.Size = new System.Drawing.Size(467, 288);
            this.incidenceGrid.TabIndex = 8;
            this.toolTip.SetToolTip(this.incidenceGrid, "Matrix");
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(758, 338);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 36);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save results";
            this.toolTip.SetToolTip(this.saveButton, "Click to save results to file");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // incidenceLabel
            // 
            this.incidenceLabel.AutoSize = true;
            this.incidenceLabel.Location = new System.Drawing.Point(366, 13);
            this.incidenceLabel.Name = "incidenceLabel";
            this.incidenceLabel.Size = new System.Drawing.Size(87, 13);
            this.incidenceLabel.TabIndex = 6;
            this.incidenceLabel.Text = "Incidence matrix:";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chooseFileButton.Location = new System.Drawing.Point(12, 338);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(75, 36);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Choose file";
            this.toolTip.SetToolTip(this.chooseFileButton, "Click to load text from file");
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // chooseDictionaryButton
            // 
            this.chooseDictionaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chooseDictionaryButton.Location = new System.Drawing.Point(93, 338);
            this.chooseDictionaryButton.Name = "chooseDictionaryButton";
            this.chooseDictionaryButton.Size = new System.Drawing.Size(75, 36);
            this.chooseDictionaryButton.TabIndex = 1;
            this.chooseDictionaryButton.Text = "Choose dictionary";
            this.toolTip.SetToolTip(this.chooseDictionaryButton, "Click to load dictionary from file");
            this.chooseDictionaryButton.UseVisualStyleBackColor = true;
            this.chooseDictionaryButton.Click += new System.EventHandler(this.chooseDictionaryButton_Click);
            // 
            // showDictionaryButton
            // 
            this.showDictionaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showDictionaryButton.Location = new System.Drawing.Point(194, 338);
            this.showDictionaryButton.Name = "showDictionaryButton";
            this.showDictionaryButton.Size = new System.Drawing.Size(75, 36);
            this.showDictionaryButton.TabIndex = 2;
            this.showDictionaryButton.Text = "Show dictionary";
            this.toolTip.SetToolTip(this.showDictionaryButton, "Click to show dictionary");
            this.showDictionaryButton.UseVisualStyleBackColor = true;
            this.showDictionaryButton.Click += new System.EventHandler(this.showDictionaryButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.Location = new System.Drawing.Point(450, 338);
            this.trackBar.Maximum = 200;
            this.trackBar.Minimum = 20;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(304, 45);
            this.trackBar.SmallChange = 5;
            this.trackBar.TabIndex = 5;
            this.trackBar.Tag = "";
            this.trackBar.Value = 20;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 385);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.showDictionaryButton);
            this.Controls.Add(this.chooseDictionaryButton);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.incidenceLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.incidenceGrid);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputTextLabelLabel);
            this.Controls.Add(this.inputDataTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(861, 423);
            this.Name = "MainForm";
            this.Text = "Incidence";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidenceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDataTextBox;
        private System.Windows.Forms.Label inputTextLabelLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView incidenceGrid;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label incidenceLabel;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button chooseDictionaryButton;
        private System.Windows.Forms.Button showDictionaryButton;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

