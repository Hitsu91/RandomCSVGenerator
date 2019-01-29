using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCSVGenerator
{
    public partial class Form1 : Form
    {
        private Randomizer rd;
        private int PreviewLines { get; set; } = 1;

        public Form1()
        {
            InitializeComponent();
            rd = new Randomizer();
            this.DateFormatPicker.DataSource = Randomizer.dateFormats;
            this.Separator.DataSource = new BindingSource(Randomizer.Separators, null);
            StartDate.Value = EndDate.Value.AddDays(-1);
        }

        private void ChangeDateFormat()
        {
            StartDate.CustomFormat = Randomizer.DefaultDateFormat;
            EndDate.CustomFormat = Randomizer.DefaultDateFormat;
        }

        private void AddNumberRange_Click(object sender, EventArgs e)
        {
            var min = MinNumber.Text;
            var max = MaxNumber.Text;

            if
            (
                double.TryParse(min, out double minDouble)
                && double.TryParse(max, out double maxDouble)
                && minDouble < maxDouble
            )
            {
                Debug.WriteLine(min + " " + max);
                int minInt, maxInt;

                if (minDouble == (minInt = (int)minDouble) && maxDouble == (maxInt = (int)maxDouble))
                    rd.AddNumberRange(minInt, maxInt);
                else
                    rd.AddNumberRange(minDouble, maxDouble);

                LoadResult();
            }
            else
                WrongNumber();
        }

        private void WrongNumber()
        {
            MinNumber.BackColor = Color.Red;
            MaxNumber.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeDateFormat();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                rd.ReadFromFile(filePath);

                LoadResult();
            }
        }

        private void LoadResult()
        {
            Results.Text = GenerateLines(PreviewLines);
        }

        private string GenerateLines()
        {
            int lines = Convert.ToInt32(NumberOfLines.Value);
            return GenerateLines(lines);
        }

        private string GenerateLines(int lines)
        {
            return rd.ToCSV(lines);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            rd.Clear();
            LoadResult();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "CSV|*.csv|Text|*.txt",
                Title = "Export data as File",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(GenerateLines());
                    }
                    stream.Close();
                }
            }
        }

        private void RemoveLast_Click(object sender, EventArgs e)
        {
            rd.RemoveLast();
            LoadResult();
        }

        private void AddNames_Click(object sender, EventArgs e)
        {
            rd.AddRandomNames();
            LoadResult();
        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            rd.AddRandomCities();
            LoadResult();
        }

        private void AddDateRange_Click(object sender, EventArgs e)
        {
            rd.AddDateRange(StartDate.Value, EndDate.Value);
            LoadResult();
        }

        private void RestoreTextBox(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
                textBox.BackColor = Color.White;
        }

        private void ChangeDateFormatPicker(object sender, EventArgs e)
        {
            Randomizer.DefaultDateFormat = (sender as ComboBox).SelectedValue.ToString();
            ChangeDateFormat();
            LoadResult();
        }

        private void ChangeSeparator(object sender, EventArgs e)
        {
            Randomizer.DefaultSeparator = (sender as ComboBox).SelectedValue.ToString();
            LoadResult();
        }

        private void LoadVector_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                rd.ReadVectorFromFile(filePath);

                LoadResult();
            }
        }

        private void SuggestionVector(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(sender as Button, Randomizer.vectorFileSuggestion);
        }
    }
}
