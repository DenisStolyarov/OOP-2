namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button_comma = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_dif = new System.Windows.Forms.Button();
            this.button_sum = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_memory_save = new System.Windows.Forms.Button();
            this.button_memory_write = new System.Windows.Forms.Button();
            this.button_ost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_comma
            // 
            this.button_comma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_comma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_comma.FlatAppearance.BorderSize = 0;
            this.button_comma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_comma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_comma.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_comma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_comma.Location = new System.Drawing.Point(12, 309);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(70, 50);
            this.button_comma.TabIndex = 0;
            this.button_comma.Text = ",";
            this.button_comma.UseVisualStyleBackColor = false;
            this.button_comma.Click += new System.EventHandler(this.SeparatorButtonClick);
            // 
            // label_result
            // 
            this.label_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_result.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_result.Location = new System.Drawing.Point(12, 27);
            this.label_result.MaximumSize = new System.Drawing.Size(300, 40);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(300, 40);
            this.label_result.TabIndex = 1;
            this.label_result.Text = "0";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_0.Location = new System.Drawing.Point(88, 309);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(70, 50);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_result
            // 
            this.button_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_result.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_result.FlatAppearance.BorderSize = 0;
            this.button_result.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_result.Location = new System.Drawing.Point(164, 309);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(70, 50);
            this.button_result.TabIndex = 3;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = false;
            this.button_result.Click += new System.EventHandler(this.ResultButtonClick);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_3.Location = new System.Drawing.Point(164, 253);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(70, 50);
            this.button_3.TabIndex = 6;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_2.Location = new System.Drawing.Point(88, 253);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(70, 50);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_1.Location = new System.Drawing.Point(12, 253);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(70, 50);
            this.button_1.TabIndex = 4;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_6.Location = new System.Drawing.Point(164, 197);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(70, 50);
            this.button_6.TabIndex = 9;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_5.Location = new System.Drawing.Point(88, 197);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(70, 50);
            this.button_5.TabIndex = 8;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_4.Location = new System.Drawing.Point(12, 197);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(70, 50);
            this.button_4.TabIndex = 7;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_9.Location = new System.Drawing.Point(164, 141);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(70, 50);
            this.button_9.TabIndex = 12;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_8.Location = new System.Drawing.Point(88, 141);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(70, 50);
            this.button_8.TabIndex = 11;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_7.Location = new System.Drawing.Point(12, 141);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(70, 50);
            this.button_7.TabIndex = 10;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_dif
            // 
            this.button_dif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_dif.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_dif.FlatAppearance.BorderSize = 0;
            this.button_dif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_dif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_dif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dif.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_dif.Location = new System.Drawing.Point(240, 253);
            this.button_dif.Name = "button_dif";
            this.button_dif.Size = new System.Drawing.Size(70, 50);
            this.button_dif.TabIndex = 14;
            this.button_dif.Text = "-";
            this.button_dif.UseVisualStyleBackColor = false;
            this.button_dif.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // button_sum
            // 
            this.button_sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_sum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_sum.FlatAppearance.BorderSize = 0;
            this.button_sum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_sum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sum.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sum.Location = new System.Drawing.Point(240, 309);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(70, 50);
            this.button_sum.TabIndex = 15;
            this.button_sum.Text = "+";
            this.button_sum.UseVisualStyleBackColor = false;
            this.button_sum.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // button_mul
            // 
            this.button_mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_mul.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_mul.FlatAppearance.BorderSize = 0;
            this.button_mul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_mul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mul.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_mul.Location = new System.Drawing.Point(240, 197);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(70, 50);
            this.button_mul.TabIndex = 16;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = false;
            this.button_mul.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // button_div
            // 
            this.button_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_div.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_div.FlatAppearance.BorderSize = 0;
            this.button_div.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_div.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_div.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_div.Location = new System.Drawing.Point(240, 141);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(70, 50);
            this.button_div.TabIndex = 17;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = false;
            this.button_div.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clear.Location = new System.Drawing.Point(12, 85);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 50);
            this.button_clear.TabIndex = 18;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_memory_save
            // 
            this.button_memory_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_memory_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_memory_save.FlatAppearance.BorderSize = 0;
            this.button_memory_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_memory_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_memory_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memory_save.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_memory_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_memory_save.Location = new System.Drawing.Point(164, 85);
            this.button_memory_save.Name = "button_memory_save";
            this.button_memory_save.Size = new System.Drawing.Size(70, 50);
            this.button_memory_save.TabIndex = 19;
            this.button_memory_save.Text = "MS";
            this.button_memory_save.UseVisualStyleBackColor = false;
            this.button_memory_save.Click += new System.EventHandler(this.button_memory_save_Click);
            // 
            // button_memory_write
            // 
            this.button_memory_write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_memory_write.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_memory_write.FlatAppearance.BorderSize = 0;
            this.button_memory_write.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_memory_write.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_memory_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memory_write.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_memory_write.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_memory_write.Location = new System.Drawing.Point(88, 85);
            this.button_memory_write.Name = "button_memory_write";
            this.button_memory_write.Size = new System.Drawing.Size(70, 50);
            this.button_memory_write.TabIndex = 20;
            this.button_memory_write.Text = "MR";
            this.button_memory_write.UseVisualStyleBackColor = false;
            this.button_memory_write.Click += new System.EventHandler(this.button_memory_write_Click);
            // 
            // button_ost
            // 
            this.button_ost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_ost.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ost.FlatAppearance.BorderSize = 0;
            this.button_ost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_ost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_ost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ost.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ost.Location = new System.Drawing.Point(240, 85);
            this.button_ost.Name = "button_ost";
            this.button_ost.Size = new System.Drawing.Size(70, 50);
            this.button_ost.TabIndex = 21;
            this.button_ost.Text = "%";
            this.button_ost.UseVisualStyleBackColor = false;
            this.button_ost.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(322, 371);
            this.Controls.Add(this.button_ost);
            this.Controls.Add(this.button_memory_write);
            this.Controls.Add(this.button_memory_save);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.button_dif);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_comma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_dif;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_memory_save;
        private System.Windows.Forms.Button button_memory_write;
        private System.Windows.Forms.Button button_ost;
    }
}

