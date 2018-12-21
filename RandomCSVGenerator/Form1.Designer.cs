using System.Windows.Forms;

namespace RandomCSVGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MinNumber = new System.Windows.Forms.TextBox();
            this.labe1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxNumber = new System.Windows.Forms.TextBox();
            this.AddNumberRange = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.RemoveLast = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.NumberOfLines = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNames = new System.Windows.Forms.Button();
            this.AddCIty = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.AddDateRange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Separator = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateFormatPicker = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoadVector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MinNumber
            // 
            this.MinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinNumber.Location = new System.Drawing.Point(16, 99);
            this.MinNumber.Name = "MinNumber";
            this.MinNumber.Size = new System.Drawing.Size(256, 26);
            this.MinNumber.TabIndex = 0;
            this.MinNumber.Text = "0";
            this.MinNumber.Enter += new System.EventHandler(this.RestoreTextBox);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe1.Location = new System.Drawing.Point(12, 76);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(127, 20);
            this.labe1.TabIndex = 1;
            this.labe1.Text = "Lowest Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Highest Number";
            // 
            // MaxNumber
            // 
            this.MaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxNumber.Location = new System.Drawing.Point(16, 151);
            this.MaxNumber.Name = "MaxNumber";
            this.MaxNumber.Size = new System.Drawing.Size(256, 26);
            this.MaxNumber.TabIndex = 2;
            this.MaxNumber.Text = "1";
            this.MaxNumber.Enter += new System.EventHandler(this.RestoreTextBox);
            // 
            // AddNumberRange
            // 
            this.AddNumberRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNumberRange.Location = new System.Drawing.Point(16, 193);
            this.AddNumberRange.Name = "AddNumberRange";
            this.AddNumberRange.Size = new System.Drawing.Size(256, 50);
            this.AddNumberRange.TabIndex = 4;
            this.AddNumberRange.Text = "Add Number Range";
            this.AddNumberRange.UseVisualStyleBackColor = true;
            this.AddNumberRange.Click += new System.EventHandler(this.AddNumberRange_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFile.Location = new System.Drawing.Point(16, 252);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(256, 50);
            this.LoadFile.TabIndex = 5;
            this.LoadFile.Text = "Load from file";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(16, 478);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(518, 60);
            this.Results.TabIndex = 7;
            this.Results.Text = "";
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(278, 545);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(256, 50);
            this.ExportButton.TabIndex = 8;
            this.ExportButton.Text = "Export CSV";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // RemoveLast
            // 
            this.RemoveLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveLast.Location = new System.Drawing.Point(16, 366);
            this.RemoveLast.Name = "RemoveLast";
            this.RemoveLast.Size = new System.Drawing.Size(256, 50);
            this.RemoveLast.TabIndex = 9;
            this.RemoveLast.Text = "Remove Last";
            this.RemoveLast.UseVisualStyleBackColor = true;
            this.RemoveLast.Click += new System.EventHandler(this.RemoveLast_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(278, 366);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(256, 50);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // NumberOfLines
            // 
            this.NumberOfLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfLines.Location = new System.Drawing.Point(16, 566);
            this.NumberOfLines.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberOfLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfLines.Name = "NumberOfLines";
            this.NumberOfLines.Size = new System.Drawing.Size(256, 26);
            this.NumberOfLines.TabIndex = 11;
            this.NumberOfLines.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "OutPut lines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preview";
            // 
            // AddNames
            // 
            this.AddNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNames.Location = new System.Drawing.Point(278, 309);
            this.AddNames.Name = "AddNames";
            this.AddNames.Size = new System.Drawing.Size(256, 50);
            this.AddNames.TabIndex = 14;
            this.AddNames.Text = "Add Names";
            this.AddNames.UseVisualStyleBackColor = true;
            this.AddNames.Click += new System.EventHandler(this.AddNames_Click);
            // 
            // AddCIty
            // 
            this.AddCIty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCIty.Location = new System.Drawing.Point(278, 252);
            this.AddCIty.Name = "AddCIty";
            this.AddCIty.Size = new System.Drawing.Size(256, 50);
            this.AddCIty.TabIndex = 15;
            this.AddCIty.Text = "Add Cities";
            this.AddCIty.UseVisualStyleBackColor = true;
            this.AddCIty.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // StartDate
            // 
            this.StartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.CustomFormat = "";
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(278, 99);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(256, 26);
            this.StartDate.TabIndex = 16;
            this.StartDate.Value = new System.DateTime(2018, 12, 19, 15, 26, 38, 344);
            // 
            // EndDate
            // 
            this.EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(278, 151);
            this.EndDate.Name = "EndDate";
            this.EndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndDate.Size = new System.Drawing.Size(256, 26);
            this.EndDate.TabIndex = 17;
            // 
            // AddDateRange
            // 
            this.AddDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDateRange.Location = new System.Drawing.Point(278, 193);
            this.AddDateRange.Name = "AddDateRange";
            this.AddDateRange.Size = new System.Drawing.Size(256, 50);
            this.AddDateRange.TabIndex = 18;
            this.AddDateRange.Text = "Add Date Range";
            this.AddDateRange.UseVisualStyleBackColor = true;
            this.AddDateRange.Click += new System.EventHandler(this.AddDateRange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Start from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Separator";
            // 
            // Separator
            // 
            this.Separator.DisplayMember = "Key";
            this.Separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Separator.FormattingEnabled = true;
            this.Separator.Location = new System.Drawing.Point(16, 42);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(256, 28);
            this.Separator.TabIndex = 23;
            this.Separator.ValueMember = "Value";
            this.Separator.SelectedIndexChanged += new System.EventHandler(this.ChangeSeparator);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DateFormatPicker
            // 
            this.DateFormatPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFormatPicker.FormattingEnabled = true;
            this.DateFormatPicker.Location = new System.Drawing.Point(278, 42);
            this.DateFormatPicker.Name = "DateFormatPicker";
            this.DateFormatPicker.Size = new System.Drawing.Size(256, 28);
            this.DateFormatPicker.TabIndex = 25;
            this.DateFormatPicker.SelectedIndexChanged += new System.EventHandler(this.ChangeDateFormatPicker);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Date Format";
            // 
            // LoadVector
            // 
            this.LoadVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadVector.Location = new System.Drawing.Point(16, 309);
            this.LoadVector.Name = "LoadVector";
            this.LoadVector.Size = new System.Drawing.Size(256, 50);
            this.LoadVector.TabIndex = 26;
            this.LoadVector.Text = "Load Vector File";
            this.LoadVector.UseVisualStyleBackColor = true;
            this.LoadVector.Click += new System.EventHandler(this.LoadVector_Click);
            this.LoadVector.MouseHover += new System.EventHandler(this.SuggestionVector);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 613);
            this.Controls.Add(this.LoadVector);
            this.Controls.Add(this.DateFormatPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddDateRange);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.AddCIty);
            this.Controls.Add(this.AddNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfLines);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.RemoveLast);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.AddNumberRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxNumber);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.MinNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CSV Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MinNumber;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxNumber;
        private System.Windows.Forms.Button AddNumberRange;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button RemoveLast;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.NumericUpDown NumberOfLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddNames;
        private System.Windows.Forms.Button AddCIty;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Button AddDateRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Separator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox DateFormatPicker;
        private System.Windows.Forms.Label label7;
        private Button LoadVector;
    }
}

