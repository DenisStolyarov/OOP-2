using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Univer
{
    public partial class MainForm : Form
    {
        private readonly StudentContext context = new StudentContext();
        private const string DeveloperName = "Denis Stoluarov";
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;
        public MainForm()
        {
            InitializeComponent();
            // Set the MinDate and MaxDate.
            dateTimePicker.MinDate = new DateTime(1960, 1, 1);
            dateTimePicker.MaxDate = DateTime.Today;
            this.comboBoxCourse.SelectedItem = this.comboBoxCourse.Items[0];

            infoLabel = new ToolStripLabel();
            infoLabel.Text = ":";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        private void ValidateAll()
        {
            var checkitems = new string[]
                {
                    this.textBoxFirstName.Text,
                    this.textBoxLastName.Text,
                    this.textBoxAddressCity.Text,
                    this.textBoxAddressHouse.Text,
                    this.textBoxAddressStreet.Text,
                    this.textBoxAge.Text,
                    this.textBoxAverageBall.Text,
                    this.textBoxGroup.Text,
                    this.textBoxPatronymic.Text,
                    this.textBoxIndex.Text,
                    this.textBoxAddressApartment.Text
                };

            this.CheckForFill(checkitems);

            if (!this.groupBoxGender.Controls.OfType<RadioButton>().Any(i => i.Checked))
            {
                throw new ArgumentException();
            }

        }

        private void CheckForFill(params string[] parameters)
        {
            foreach (var item in parameters)
            {
                if (string.IsNullOrEmpty(item))
                {
                    throw new ArgumentException();
                }
            }
        }

        private void TextBoxDigitKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void NameValidating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg = "Wrong format : must start from upper symbol and have min lenght 2";
            var obj = sender as TextBox;
            if (obj is null)
            {
                throw new NullReferenceException();
            }

            if (!(obj.Text.Length > 0 && char.IsUpper(obj.Text.First())))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                obj.Select(0, obj.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderName.SetError(obj, errorMsg);
            }
        }

        private void NameValidated(object sender, System.EventArgs e)
        {
            var obj = sender as TextBox;
            if (obj is null)
            {
                throw new NullReferenceException();
            }

            // If all conditions have been met, clear the ErrorProvider of errors.
            this.errorProviderName.SetError(obj, string.Empty);
        }

        private void MarkValidating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg = "Not correct mark:";
            var obj = sender as TextBox;
            if (obj is null)
            {
                throw new NullReferenceException();
            }

            if (!double.TryParse(obj.Text, out double result) || result < 0 || obj.Text.Length < 1)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                obj.Select(0, obj.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderMark.SetError(obj, errorMsg);
            }
        }

        private void MarkValidated(object sender, System.EventArgs e)
        {
            var obj = sender as TextBox;
            if (obj is null)
            {
                throw new NullReferenceException();
            }

            // If all conditions have been met, clear the ErrorProvider of errors.
            this.errorProviderMark.SetError(obj, string.Empty);
        }

        private void NumberValidating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg = "Not correct number";
            var obj = sender as TextBox;
            if (obj is null)
            {
                throw new NullReferenceException();
            }

            if (!int.TryParse(obj.Text, out int result) || obj.Text.Length < 1 || result < 0)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                obj.Select(0, obj.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderMark.SetError(obj, errorMsg);
            }
        }

        private void CheckBoxValidating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg = "Choose gender";
            var obj = sender as GroupBox;
            if (obj is null)
            {
                throw new NullReferenceException();
            }

            if (!obj.Controls.OfType<RadioButton>().Any(i => i.Checked))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderMark.SetError(obj, errorMsg);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateAll();
                var student = new Student();
                var address = new Address();

                student.FirstName = this.textBoxFirstName.Text;
                student.LastName = this.textBoxLastName.Text;
                address.Apartment = int.Parse(this.textBoxAddressApartment.Text);
                address.City = this.textBoxAddressCity.Text;
                address.House = int.Parse(this.textBoxAddressHouse.Text);
                address.Street = this.textBoxAddressStreet.Text;
                student.Age = int.Parse(this.textBoxAge.Text);
                student.AverageBall = double.Parse(this.textBoxAverageBall.Text);
                student.Group = int.Parse(this.textBoxGroup.Text);
                student.Patronymic = this.textBoxPatronymic.Text;
                address.Index = int.Parse(this.textBoxIndex.Text);
                student.Course = int.Parse(this.comboBoxCourse.SelectedItem.ToString());
                student.DateOfBirth = this.dateTimePicker.Value;
                student.Gender = this.groupBoxGender.Controls.OfType<RadioButton>().First(i => i.Checked).Text.First();
                student.HomeAddress = address;

                this.context.Student.Add(student);
                this.context.SaveChanges();

                MessageBox.Show("Record was added!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Fill all data!");
            }
        }

        private void Show(object sender, EventArgs e)
        {
            this.textBoxScreen.Text = string.Empty;
            foreach (var item in this.context.Student.Include(i => i.HomeAddress))
            {
                this.textBoxScreen.Text += item.ToString() + Environment.NewLine;
            }
        }

        private void buttonSaveJson_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("Json.json", true))
            {
                writer.Write(JsonSerializer.Serialize(this.context.Student.Include(i => i.HomeAddress)));
            }
        }

        private void buttonReadJson_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text = string.Empty;
            using (var reader = new StreamReader("Json.json"))
            {
                var result = reader.ReadToEnd();
                var records = JsonSerializer.Deserialize<List<Student>>(result);
                foreach (var item in records)
                {
                    this.textBoxScreen.Text += item.ToString() + Environment.NewLine;
                }
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Version: {new Version(new Random().Next().ToString()).Major} - {DeveloperName}");
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text = string.Empty;
            foreach (var item in this.context.Student.Include(i => i.HomeAddress).OrderBy(i => i.FirstName).ThenBy(i => i.LastName).ThenBy(i => i.Patronymic))
            {
                this.textBoxScreen.Text += item.ToString() + Environment.NewLine;
            }
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text = string.Empty;
            foreach (var item in this.context.Student.Include(i => i.HomeAddress).OrderBy(i => i.Course))
            {
                this.textBoxScreen.Text += item.ToString() + Environment.NewLine;
            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text = string.Empty;
            foreach (var item in this.context.Student.Include(i => i.HomeAddress).OrderBy(i => i.Group))
            {
                this.textBoxScreen.Text += item.ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var search = new SearchForm())
            {
                search.ShowDialog();
            }
        }
    }
}
