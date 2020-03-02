namespace CollectionGenerator
{
    partial class Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.CollectionSize = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.Button();
            this.Interval = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Descending = new System.Windows.Forms.Button();
            this.Ascending = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FromInterval = new System.Windows.Forms.TextBox();
            this.ToInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Collection Size";
            // 
            // CollectionSize
            // 
            this.CollectionSize.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CollectionSize.Location = new System.Drawing.Point(12, 43);
            this.CollectionSize.Name = "CollectionSize";
            this.CollectionSize.Size = new System.Drawing.Size(156, 30);
            this.CollectionSize.TabIndex = 1;
            this.CollectionSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.White;
            this.Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Generate.Location = new System.Drawing.Point(12, 87);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(156, 37);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.White;
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Screen.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Screen.Location = new System.Drawing.Point(214, 172);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.ReadOnly = true;
            this.Screen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Screen.Size = new System.Drawing.Size(310, 195);
            this.Screen.TabIndex = 3;
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.Color.White;
            this.Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Max.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Max.Location = new System.Drawing.Point(12, 275);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(156, 37);
            this.Max.TabIndex = 5;
            this.Max.Text = "Max Value";
            this.Max.UseVisualStyleBackColor = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Interval
            // 
            this.Interval.BackColor = System.Drawing.Color.White;
            this.Interval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Interval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Interval.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Interval.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Interval.Location = new System.Drawing.Point(12, 223);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(156, 37);
            this.Interval.TabIndex = 6;
            this.Interval.Text = "Interval";
            this.Interval.UseVisualStyleBackColor = false;
            this.Interval.Click += new System.EventHandler(this.Interval_Click);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.White;
            this.Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Min.Location = new System.Drawing.Point(12, 330);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(156, 37);
            this.Min.TabIndex = 7;
            this.Min.Text = "Min Value";
            this.Min.UseVisualStyleBackColor = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Descending
            // 
            this.Descending.BackColor = System.Drawing.Color.White;
            this.Descending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Descending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Descending.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Descending.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Descending.Location = new System.Drawing.Point(214, 34);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(310, 47);
            this.Descending.TabIndex = 8;
            this.Descending.Text = "Descending";
            this.Descending.UseVisualStyleBackColor = false;
            this.Descending.Click += new System.EventHandler(this.Descending_Click);
            // 
            // Ascending
            // 
            this.Ascending.BackColor = System.Drawing.Color.White;
            this.Ascending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ascending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ascending.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ascending.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Ascending.Location = new System.Drawing.Point(214, 87);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(310, 47);
            this.Ascending.TabIndex = 9;
            this.Ascending.Text = "Ascending";
            this.Ascending.UseVisualStyleBackColor = false;
            this.Ascending.Click += new System.EventHandler(this.Ascending_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // FromInterval
            // 
            this.FromInterval.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromInterval.Location = new System.Drawing.Point(13, 172);
            this.FromInterval.Name = "FromInterval";
            this.FromInterval.Size = new System.Drawing.Size(56, 30);
            this.FromInterval.TabIndex = 11;
            // 
            // ToInterval
            // 
            this.ToInterval.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToInterval.Location = new System.Drawing.Point(112, 172);
            this.ToInterval.Name = "ToInterval";
            this.ToInterval.Size = new System.Drawing.Size(56, 30);
            this.ToInterval.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(138, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "To";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(536, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToInterval);
            this.Controls.Add(this.FromInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ascending);
            this.Controls.Add(this.Descending);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.CollectionSize);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Generator";
            this.Text = "CollectionGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CollectionSize;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Interval;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Descending;
        private System.Windows.Forms.Button Ascending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FromInterval;
        private System.Windows.Forms.TextBox ToInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

