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
            this.inputDataTextBox = new System.Windows.Forms.TextBox();
            this.inputTextLabelLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.incidenceGrid = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.incidenceLabel = new System.Windows.Forms.Label();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.incidenceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDataTextBox
            // 
            this.inputDataTextBox.Location = new System.Drawing.Point(13, 35);
            this.inputDataTextBox.Multiline = true;
            this.inputDataTextBox.Name = "inputDataTextBox";
            this.inputDataTextBox.Size = new System.Drawing.Size(337, 288);
            this.inputDataTextBox.TabIndex = 0;
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
            this.calculateButton.Location = new System.Drawing.Point(275, 341);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(180, 341);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // incidenceGrid
            // 
            this.incidenceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidenceGrid.Location = new System.Drawing.Point(420, 35);
            this.incidenceGrid.Name = "incidenceGrid";
            this.incidenceGrid.Size = new System.Drawing.Size(288, 288);
            this.incidenceGrid.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(633, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // incidenceLabel
            // 
            this.incidenceLabel.AutoSize = true;
            this.incidenceLabel.Location = new System.Drawing.Point(420, 13);
            this.incidenceLabel.Name = "incidenceLabel";
            this.incidenceLabel.Size = new System.Drawing.Size(87, 13);
            this.incidenceLabel.TabIndex = 6;
            this.incidenceLabel.Text = "Incidence matrix:";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(13, 341);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(75, 23);
            this.chooseFileButton.TabIndex = 7;
            this.chooseFileButton.Text = "Choose file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 379);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.incidenceLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.incidenceGrid);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputTextLabelLabel);
            this.Controls.Add(this.inputDataTextBox);
            this.Name = "MainForm";
            this.Text = "Incidence";
            ((System.ComponentModel.ISupportInitialize)(this.incidenceGrid)).EndInit();
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
    }
}

