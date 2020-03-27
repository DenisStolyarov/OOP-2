using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Univer
{
    public partial class SearchForm : Form
    {
        private readonly StudentContext context = new StudentContext();
        private IQueryable<Student> query;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.query = this.context.Student.Include(i => i.HomeAddress);

            if (!string.IsNullOrEmpty(this.textBoxFirstName.Text))
            {
                this.query = this.query.Where(i => i.FirstName.Equals(this.textBoxFirstName.Text));
            }

            if (int.TryParse(this.textBoxGroup.Text, out int group))
            {
                this.query = this.query.Where(i => i.Group.Equals(group));
            }

            if (this.comboBoxCourse.SelectedIndex > -1)
            {
                this.query = this.query.Where(i => i.Course.Equals(int.Parse(this.comboBoxCourse.SelectedItem.ToString())));
            }

            this.textBoxScreen.Text = string.Empty;
            foreach (var item in this.query.AsEnumerable())
            {
                this.textBoxScreen.Text += item.ToString() + Environment.NewLine;
            }
        }
    }
}
