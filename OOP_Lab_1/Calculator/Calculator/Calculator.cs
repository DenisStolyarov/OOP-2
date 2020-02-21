using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private readonly string outputDefaultValue = "0";
        private readonly int lableMaxSize = 16;
        private StringBuilder resultBuffer = new StringBuilder();
        private string memoryValue = "0";
        private string operation = string.Empty;
        private bool isSeparated = false;
        private bool hasOperation = false;

        private Dictionary<string, Func<double, double, double>> calculator = new Dictionary<string, Func<double, double, double>>()
        {
            {"+", (double a, double b) => a + b },
            {"-", (double a, double b) => a - b },
            {"*", (double a, double b) => a * b },
            {"/", (double a, double b) => a / b },
            {"%", (double a, double b) => a % b },
        };

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            if (this.hasOperation)
            {
                this.isSeparated = false;
            }

            this.MakeOrDefault();
            this.FillResultLabel(((Button)sender).Text);
        }

        private void FillResultLabel(string word, bool removeLast = false)
        {
            if (removeLast)
            {
                int lastSymbolPosition = this.label_result.Text.Length - 1;
                this.label_result.Text = this.label_result.Text.Remove(lastSymbolPosition);
                this.resultBuffer.Remove(lastSymbolPosition, 1);
            }

            this.label_result.Text += word;

            if (this.label_result.Text.Length > this.lableMaxSize)
            {
                // Move result on right.
                this.label_result.Text = this.label_result.Text.Remove(0, 1);
            }

            this.resultBuffer.Append(word);
        }
        private void SeparatorButtonClick(object sender, EventArgs e)
        {
            if (!this.isSeparated)
            {
                this.FillResultLabel(this.button_comma.Text);
                isSeparated = true;
            }
        }

        private void MakeOrDefault()
        {
            if (this.label_result.Text.Equals(this.outputDefaultValue, StringComparison.InvariantCulture))
            {
                this.label_result.Text = string.Empty;
            }
        }

        private void OperationButtonClick(object sender, EventArgs e)
        {
            if (this.hasOperation)
            {
                return;
            }

            this.operation = ((Button)sender).Text;
            FillResultLabel(this.operation, hasOperation);
            this.hasOperation = true;
        }

        private void ResultButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.operation))
            {
                return;
            }

            const int firstValueIndex = 0;
            const int secondValueIndex = 1;
            var numbers = this.resultBuffer.ToString().Split(this.operation.First());
            if (numbers.Length < 2)
            {
                return;
            }

            if (!double.TryParse(numbers[firstValueIndex], out double firstValue))
            {
                this.Reset();
                return;
            }

            if (!double.TryParse(numbers[secondValueIndex], out double secondValue))
            {
                this.Reset();
                return;
            }

            var result = this.calculator[this.operation].Invoke(firstValue, secondValue);
            this.Reset();
            this.MakeOrDefault();
            this.FillResultLabel(result.ToString());
        }

        private void Reset()
        {
            this.resultBuffer.Clear();
            this.label_result.Text = outputDefaultValue;
            this.hasOperation = false;
            this.operation = string.Empty;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void button_memory_save_Click(object sender, EventArgs e)
        {
            if (!this.hasOperation)
            {
                this.memoryValue = this.label_result.Text;
            }
        }

        private void button_memory_write_Click(object sender, EventArgs e)
        {
            this.MakeOrDefault();
            if (!this.label_result.Text.Equals(this.memoryValue, StringComparison.InvariantCulture))
            {
                this.FillResultLabel(this.memoryValue);
            }
        }
    }
}
