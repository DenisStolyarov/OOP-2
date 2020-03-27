namespace Univer
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.textBoxScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 34);
            this.textBoxFirstName.MaxLength = 30;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(183, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 18);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(15, 129);
            this.textBoxGroup.MaxLength = 60;
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(180, 20);
            this.textBoxGroup.TabIndex = 18;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(12, 113);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(36, 13);
            this.labelGroup.TabIndex = 17;
            this.labelGroup.Text = "Group";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCourse.Location = new System.Drawing.Point(15, 83);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCourse.TabIndex = 16;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(12, 67);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(40, 13);
            this.labelCourse.TabIndex = 15;
            this.labelCourse.Text = "Course";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(15, 180);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 36);
            this.Search.TabIndex = 19;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBoxScreen
            // 
            this.textBoxScreen.Location = new System.Drawing.Point(215, 34);
            this.textBoxScreen.Multiline = true;
            this.textBoxScreen.Name = "textBoxScreen";
            this.textBoxScreen.ReadOnly = true;
            this.textBoxScreen.Size = new System.Drawing.Size(537, 182);
            this.textBoxScreen.TabIndex = 20;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 239);
            this.Controls.Add(this.textBoxScreen);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBoxScreen;
    }
}