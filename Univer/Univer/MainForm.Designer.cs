namespace Univer
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxAverageBall = new System.Windows.Forms.TextBox();
            this.labelAverageBall = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.textBoxAddressApartment = new System.Windows.Forms.TextBox();
            this.textBoxAddressStreet = new System.Windows.Forms.TextBox();
            this.labelAddressStreet = new System.Windows.Forms.Label();
            this.labelAddressApartment = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxAddressHouse = new System.Windows.Forms.TextBox();
            this.labelAddressHouse = new System.Windows.Forms.Label();
            this.textBoxAddressCity = new System.Windows.Forms.TextBox();
            this.labelAddressIndex = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSaveJson = new System.Windows.Forms.Button();
            this.buttonReadJson = new System.Windows.Forms.Button();
            this.textBoxScreen = new System.Windows.Forms.TextBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMark = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(5, 38);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(8, 54);
            this.textBoxFirstName.MaxLength = 30;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(183, 20);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.NameValidating);
            this.textBoxFirstName.Validated += new System.EventHandler(this.NameValidated);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(217, 54);
            this.textBoxLastName.MaxLength = 30;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(176, 20);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.NameValidating);
            this.textBoxLastName.Validated += new System.EventHandler(this.NameValidated);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(214, 38);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(217, 93);
            this.textBoxPatronymic.MaxLength = 30;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(176, 20);
            this.textBoxPatronymic.TabIndex = 5;
            this.textBoxPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this.NameValidating);
            this.textBoxPatronymic.Validated += new System.EventHandler(this.NameValidated);
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(214, 77);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(59, 13);
            this.labelPatronymic.TabIndex = 4;
            this.labelPatronymic.Text = "Patronymic";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(8, 93);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(183, 20);
            this.textBoxAge.TabIndex = 7;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigitKeyPress);
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.NumberValidating);
            this.textBoxAge.Validated += new System.EventHandler(this.MarkValidated);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(5, 77);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date Of Birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(8, 138);
            this.dateTimePicker.MaxDate = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(2020, 3, 13, 0, 0, 0, 0);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(8, 245);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(40, 13);
            this.labelCourse.TabIndex = 10;
            this.labelCourse.Text = "Course";
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
            this.comboBoxCourse.Location = new System.Drawing.Point(11, 261);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCourse.TabIndex = 12;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(11, 307);
            this.textBoxGroup.MaxLength = 60;
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(180, 20);
            this.textBoxGroup.TabIndex = 14;
            this.textBoxGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigitKeyPress);
            this.textBoxGroup.Validating += new System.ComponentModel.CancelEventHandler(this.NumberValidating);
            this.textBoxGroup.Validated += new System.EventHandler(this.MarkValidated);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(8, 291);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(36, 13);
            this.labelGroup.TabIndex = 13;
            this.labelGroup.Text = "Group";
            // 
            // textBoxAverageBall
            // 
            this.textBoxAverageBall.Location = new System.Drawing.Point(11, 353);
            this.textBoxAverageBall.MaxLength = 60;
            this.textBoxAverageBall.Name = "textBoxAverageBall";
            this.textBoxAverageBall.Size = new System.Drawing.Size(180, 20);
            this.textBoxAverageBall.TabIndex = 16;
            this.textBoxAverageBall.Validating += new System.ComponentModel.CancelEventHandler(this.MarkValidating);
            this.textBoxAverageBall.Validated += new System.EventHandler(this.MarkValidated);
            // 
            // labelAverageBall
            // 
            this.labelAverageBall.AutoSize = true;
            this.labelAverageBall.Location = new System.Drawing.Point(8, 337);
            this.labelAverageBall.Name = "labelAverageBall";
            this.labelAverageBall.Size = new System.Drawing.Size(64, 13);
            this.labelAverageBall.TabIndex = 15;
            this.labelAverageBall.Text = "AverageBall";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonfemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(8, 171);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(183, 63);
            this.groupBoxGender.TabIndex = 17;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            this.groupBoxGender.Validating += new System.ComponentModel.CancelEventHandler(this.CheckBoxValidating);
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.Location = new System.Drawing.Point(6, 42);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonfemale.TabIndex = 1;
            this.radioButtonfemale.TabStop = true;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.textBoxAddressApartment);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressStreet);
            this.groupBoxAddress.Controls.Add(this.labelAddressStreet);
            this.groupBoxAddress.Controls.Add(this.labelAddressApartment);
            this.groupBoxAddress.Controls.Add(this.labelCity);
            this.groupBoxAddress.Controls.Add(this.textBoxIndex);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressHouse);
            this.groupBoxAddress.Controls.Add(this.labelAddressHouse);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressCity);
            this.groupBoxAddress.Controls.Add(this.labelAddressIndex);
            this.groupBoxAddress.Location = new System.Drawing.Point(217, 122);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(176, 251);
            this.groupBoxAddress.TabIndex = 18;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // textBoxAddressApartment
            // 
            this.textBoxAddressApartment.Location = new System.Drawing.Point(6, 225);
            this.textBoxAddressApartment.MaxLength = 60;
            this.textBoxAddressApartment.Name = "textBoxAddressApartment";
            this.textBoxAddressApartment.Size = new System.Drawing.Size(163, 20);
            this.textBoxAddressApartment.TabIndex = 28;
            this.textBoxAddressApartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigitKeyPress);
            this.textBoxAddressApartment.Validating += new System.ComponentModel.CancelEventHandler(this.NumberValidating);
            this.textBoxAddressApartment.Validated += new System.EventHandler(this.MarkValidated);
            // 
            // textBoxAddressStreet
            // 
            this.textBoxAddressStreet.Location = new System.Drawing.Point(6, 133);
            this.textBoxAddressStreet.MaxLength = 60;
            this.textBoxAddressStreet.Name = "textBoxAddressStreet";
            this.textBoxAddressStreet.Size = new System.Drawing.Size(163, 20);
            this.textBoxAddressStreet.TabIndex = 24;
            this.textBoxAddressStreet.Validating += new System.ComponentModel.CancelEventHandler(this.NameValidating);
            this.textBoxAddressStreet.Validated += new System.EventHandler(this.NameValidated);
            // 
            // labelAddressStreet
            // 
            this.labelAddressStreet.AutoSize = true;
            this.labelAddressStreet.Location = new System.Drawing.Point(3, 117);
            this.labelAddressStreet.Name = "labelAddressStreet";
            this.labelAddressStreet.Size = new System.Drawing.Size(35, 13);
            this.labelAddressStreet.TabIndex = 23;
            this.labelAddressStreet.Text = "Street";
            // 
            // labelAddressApartment
            // 
            this.labelAddressApartment.AutoSize = true;
            this.labelAddressApartment.Location = new System.Drawing.Point(3, 209);
            this.labelAddressApartment.Name = "labelAddressApartment";
            this.labelAddressApartment.Size = new System.Drawing.Size(55, 13);
            this.labelAddressApartment.TabIndex = 27;
            this.labelAddressApartment.Text = "Apartment";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(3, 27);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "City";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(6, 88);
            this.textBoxIndex.MaxLength = 60;
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(163, 20);
            this.textBoxIndex.TabIndex = 22;
            this.textBoxIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigitKeyPress);
            this.textBoxIndex.Validating += new System.ComponentModel.CancelEventHandler(this.NumberValidating);
            this.textBoxIndex.Validated += new System.EventHandler(this.MarkValidated);
            // 
            // textBoxAddressHouse
            // 
            this.textBoxAddressHouse.Location = new System.Drawing.Point(6, 180);
            this.textBoxAddressHouse.MaxLength = 60;
            this.textBoxAddressHouse.Name = "textBoxAddressHouse";
            this.textBoxAddressHouse.Size = new System.Drawing.Size(163, 20);
            this.textBoxAddressHouse.TabIndex = 26;
            this.textBoxAddressHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigitKeyPress);
            this.textBoxAddressHouse.Validating += new System.ComponentModel.CancelEventHandler(this.NumberValidating);
            this.textBoxAddressHouse.Validated += new System.EventHandler(this.MarkValidated);
            // 
            // labelAddressHouse
            // 
            this.labelAddressHouse.AutoSize = true;
            this.labelAddressHouse.Location = new System.Drawing.Point(3, 164);
            this.labelAddressHouse.Name = "labelAddressHouse";
            this.labelAddressHouse.Size = new System.Drawing.Size(38, 13);
            this.labelAddressHouse.TabIndex = 25;
            this.labelAddressHouse.Text = "House";
            // 
            // textBoxAddressCity
            // 
            this.textBoxAddressCity.Location = new System.Drawing.Point(6, 43);
            this.textBoxAddressCity.MaxLength = 60;
            this.textBoxAddressCity.Name = "textBoxAddressCity";
            this.textBoxAddressCity.Size = new System.Drawing.Size(163, 20);
            this.textBoxAddressCity.TabIndex = 20;
            this.textBoxAddressCity.Validating += new System.ComponentModel.CancelEventHandler(this.NameValidating);
            this.textBoxAddressCity.Validated += new System.EventHandler(this.NameValidated);
            // 
            // labelAddressIndex
            // 
            this.labelAddressIndex.AutoSize = true;
            this.labelAddressIndex.Location = new System.Drawing.Point(3, 72);
            this.labelAddressIndex.Name = "labelAddressIndex";
            this.labelAddressIndex.Size = new System.Drawing.Size(33, 13);
            this.labelAddressIndex.TabIndex = 21;
            this.labelAddressIndex.Text = "Index";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(422, 54);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 36);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSaveJson
            // 
            this.buttonSaveJson.Location = new System.Drawing.Point(422, 110);
            this.buttonSaveJson.Name = "buttonSaveJson";
            this.buttonSaveJson.Size = new System.Drawing.Size(182, 36);
            this.buttonSaveJson.TabIndex = 22;
            this.buttonSaveJson.Text = "Save Json";
            this.buttonSaveJson.UseVisualStyleBackColor = true;
            this.buttonSaveJson.Click += new System.EventHandler(this.buttonSaveJson_Click);
            // 
            // buttonReadJson
            // 
            this.buttonReadJson.Location = new System.Drawing.Point(422, 171);
            this.buttonReadJson.Name = "buttonReadJson";
            this.buttonReadJson.Size = new System.Drawing.Size(182, 36);
            this.buttonReadJson.TabIndex = 23;
            this.buttonReadJson.Text = "Read Json";
            this.buttonReadJson.UseVisualStyleBackColor = true;
            this.buttonReadJson.Click += new System.EventHandler(this.buttonReadJson_Click);
            // 
            // textBoxScreen
            // 
            this.textBoxScreen.Location = new System.Drawing.Point(11, 394);
            this.textBoxScreen.Multiline = true;
            this.textBoxScreen.Name = "textBoxScreen";
            this.textBoxScreen.ReadOnly = true;
            this.textBoxScreen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxScreen.Size = new System.Drawing.Size(776, 244);
            this.textBoxScreen.TabIndex = 24;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderMark
            // 
            this.errorProviderMark.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Show);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.showToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.groupToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 36);
            this.button2.TabIndex = 28;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.Show);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 611);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 633);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxScreen);
            this.Controls.Add(this.buttonReadJson);
            this.Controls.Add(this.buttonSaveJson);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.textBoxAverageBall);
            this.Controls.Add(this.labelAverageBall);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "MainForm";
            this.Text = "Univer";
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxAverageBall;
        private System.Windows.Forms.Label labelAverageBall;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.TextBox textBoxAddressStreet;
        private System.Windows.Forms.Label labelAddressStreet;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxAddressCity;
        private System.Windows.Forms.Label labelAddressIndex;
        private System.Windows.Forms.TextBox textBoxAddressApartment;
        private System.Windows.Forms.Label labelAddressApartment;
        private System.Windows.Forms.TextBox textBoxAddressHouse;
        private System.Windows.Forms.Label labelAddressHouse;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSaveJson;
        private System.Windows.Forms.Button buttonReadJson;
        private System.Windows.Forms.TextBox textBoxScreen;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

