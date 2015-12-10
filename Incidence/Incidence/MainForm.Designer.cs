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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.incidenceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataTextBox
            // 
            this.inputDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputDataTextBox.Location = new System.Drawing.Point(13, 53);
            this.inputDataTextBox.Multiline = true;
            this.inputDataTextBox.Name = "inputDataTextBox";
            this.inputDataTextBox.Size = new System.Drawing.Size(337, 304);
            this.inputDataTextBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.inputDataTextBox, "Text");
            // 
            // inputTextLabelLabel
            // 
            this.inputTextLabelLabel.AutoSize = true;
            this.inputTextLabelLabel.Location = new System.Drawing.Point(12, 32);
            this.inputTextLabelLabel.Name = "inputTextLabelLabel";
            this.inputTextLabelLabel.Size = new System.Drawing.Size(88, 13);
            this.inputTextLabelLabel.TabIndex = 1;
            this.inputTextLabelLabel.Text = "Please input text:";
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateButton.Location = new System.Drawing.Point(366, 372);
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
            this.clearButton.Location = new System.Drawing.Point(275, 372);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incidenceGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.incidenceGrid.Location = new System.Drawing.Point(366, 53);
            this.incidenceGrid.Name = "incidenceGrid";
            this.incidenceGrid.RowHeadersWidth = 150;
            this.incidenceGrid.Size = new System.Drawing.Size(467, 304);
            this.incidenceGrid.TabIndex = 8;
            this.toolTip.SetToolTip(this.incidenceGrid, "Matrix");
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(758, 372);
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
            this.incidenceLabel.Location = new System.Drawing.Point(363, 32);
            this.incidenceLabel.Name = "incidenceLabel";
            this.incidenceLabel.Size = new System.Drawing.Size(87, 13);
            this.incidenceLabel.TabIndex = 6;
            this.incidenceLabel.Text = "Incidence matrix:";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chooseFileButton.Location = new System.Drawing.Point(12, 372);
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
            this.chooseDictionaryButton.Location = new System.Drawing.Point(93, 372);
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
            this.showDictionaryButton.Location = new System.Drawing.Point(194, 372);
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
            this.trackBar.Location = new System.Drawing.Point(450, 372);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.menuToolStripMenuItem,
            this.aToolStripMenuItem,
            this.calculateModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem1.Text = "&Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choosefileToolStripMenuItem,
            this.chooseDictionaryToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.menuToolStripMenuItem.Text = "&Data";
            // 
            // choosefileToolStripMenuItem
            // 
            this.choosefileToolStripMenuItem.Name = "choosefileToolStripMenuItem";
            this.choosefileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.choosefileToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.choosefileToolStripMenuItem.Text = "Choose &file";
            this.choosefileToolStripMenuItem.Click += new System.EventHandler(this.choosefileToolStripMenuItem_Click);
            // 
            // chooseDictionaryToolStripMenuItem
            // 
            this.chooseDictionaryToolStripMenuItem.Name = "chooseDictionaryToolStripMenuItem";
            this.chooseDictionaryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.chooseDictionaryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.chooseDictionaryToolStripMenuItem.Text = "Choose &dictionary";
            this.chooseDictionaryToolStripMenuItem.Click += new System.EventHandler(this.chooseDictionaryToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDictionaryToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.saveResultsToFileToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aToolStripMenuItem.Text = "&Actions";
            // 
            // showDictionaryToolStripMenuItem
            // 
            this.showDictionaryToolStripMenuItem.Name = "showDictionaryToolStripMenuItem";
            this.showDictionaryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.showDictionaryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showDictionaryToolStripMenuItem.Text = "&Show dictionary";
            this.showDictionaryToolStripMenuItem.Click += new System.EventHandler(this.showDictionaryToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // saveResultsToFileToolStripMenuItem
            // 
            this.saveResultsToFileToolStripMenuItem.Name = "saveResultsToFileToolStripMenuItem";
            this.saveResultsToFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.saveResultsToFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveResultsToFileToolStripMenuItem.Text = "Save results to file";
            this.saveResultsToFileToolStripMenuItem.Click += new System.EventHandler(this.saveResultsToFileToolStripMenuItem_Click);
            // 
            // calculateModeToolStripMenuItem
            // 
            this.calculateModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem});
            this.calculateModeToolStripMenuItem.Name = "calculateModeToolStripMenuItem";
            this.calculateModeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.calculateModeToolStripMenuItem.Text = "Calculate mode";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Checked = true;
            this.autoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 419);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(861, 457);
            this.Name = "MainForm";
            this.Text = "Incidence";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidenceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
    }
}

