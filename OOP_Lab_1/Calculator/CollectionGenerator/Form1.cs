using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionGenerator
{
    public partial class Generator : Form
    {
        private readonly List<Randomer> randomers = new List<Randomer>();
        public Generator()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            var minSize = 0;
            
            this.Clear();

            if (!TryConverter(this.CollectionSize.Text, out int collectionSize))
            {
                return;
            }

            if (collectionSize < minSize)
            {
                MessageBox.Show($"Min size: {minSize}");
                return;
            }

            for (int i = 0; i < collectionSize; i++)
            {
                this.randomers.Add(new Randomer());
            }

            this.Display();
        }

        private bool TryConverter(string parameters, out int result)
        {
            if (int.TryParse(parameters, out result))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Wrong parameter: {parameters}");
                return false;
            }
        }

        private void Display()
        {
            if (this.isEmpty())
            {
                return;
            }

            var builder = new StringBuilder();
            
            foreach (var randomer in this.randomers)
            {
                builder.Append(randomer + Environment.NewLine);
            }

            this.Screen.Text = builder.ToString();
        }

        private void Clear()
        {
            this.randomers.Clear();
            this.Screen.Text = string.Empty;
        }

        private bool isEmpty()
        {
            return this.randomers.Count.Equals(0) ? true : false;

        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                return;
            }

            var max = this.randomers.Max(i=>i.Value);
            this.Screen.Text = $"Max value: {max}";
        }

        private void Min_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                return;
            }

            var min = this.randomers.Min(i => i.Value);
            this.Screen.Text = $"Min value: {min}";
        }

        private void Interval_Click(object sender, EventArgs e)
        {
            if (!this.TryConverter(this.FromInterval.Text, out int from))
            {
                return;
            }

            if (!this.TryConverter(this.ToInterval.Text, out int to))
            {
                return;
            }

            if (from > to)
            {
                MessageBox.Show($"Wrong interval: [{from}, {to}]");
                return;
            }

            var interval = this.randomers.Where((i) => (i.Value >= from) && (i.Value <= to));

            if (interval.Count().Equals(0))
            {
                MessageBox.Show($"No values in interval: [{from}, {to}]");
                return;
            }

            var builder = new StringBuilder();

            foreach (var item in interval)
            {
                builder.Append(item + Environment.NewLine);
            }

            this.Screen.Text = builder.ToString();
        }

        private void Descending_Click(object sender, EventArgs e)
        {
            this.Sort(new DescendingComporator());
        }

        private void Ascending_Click(object sender, EventArgs e)
        {
            this.Sort(new AscendingComporator());
        }

        private void Sort (IComparer<Randomer> comparer)
        {
            this.randomers.Sort(comparer);
            this.Display();
        }
    }
}
