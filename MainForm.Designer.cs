namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.resultButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OGTextBox = new System.Windows.Forms.NumericUpDown();
            this.OTTextBox = new System.Windows.Forms.NumericUpDown();
            this.DITextBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.OGlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DRTextBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OBTextBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Izb = new System.Windows.Forms.Button();
            this.PBizb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OGTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DITextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRTextBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OBTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBizb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.Location = new System.Drawing.Point(17, 279);
            this.resultButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(196, 39);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "Показать результат";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OGTextBox
            // 
            this.OGTextBox.Location = new System.Drawing.Point(183, 47);
            this.OGTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OGTextBox.Name = "OGTextBox";
            this.OGTextBox.Size = new System.Drawing.Size(62, 22);
            this.OGTextBox.TabIndex = 3;
            this.OGTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OGTextBox.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.OGTextBox.ValueChanged += new System.EventHandler(this.resultButton_Click);
            // 
            // OTTextBox
            // 
            this.OTTextBox.Location = new System.Drawing.Point(183, 88);
            this.OTTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OTTextBox.Name = "OTTextBox";
            this.OTTextBox.Size = new System.Drawing.Size(62, 22);
            this.OTTextBox.TabIndex = 4;
            this.OTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OTTextBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.OTTextBox.ValueChanged += new System.EventHandler(this.resultButton_Click);
            // 
            // DITextBox
            // 
            this.DITextBox.Location = new System.Drawing.Point(183, 129);
            this.DITextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DITextBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.DITextBox.Name = "DITextBox";
            this.DITextBox.Size = new System.Drawing.Size(62, 22);
            this.DITextBox.TabIndex = 6;
            this.DITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DITextBox.ValueChanged += new System.EventHandler(this.resultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Обхват Бёдер:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OGlabel
            // 
            this.OGlabel.AutoSize = true;
            this.OGlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OGlabel.Location = new System.Drawing.Point(7, 41);
            this.OGlabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.OGlabel.Name = "OGlabel";
            this.OGlabel.Size = new System.Drawing.Size(162, 41);
            this.OGlabel.TabIndex = 8;
            this.OGlabel.Text = "Охват Груди:";
            this.OGlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Обхват Талии";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 41);
            this.label4.TabIndex = 10;
            this.label4.Text = "Длина Изделия:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DRTextBox
            // 
            this.DRTextBox.Location = new System.Drawing.Point(183, 170);
            this.DRTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DRTextBox.Name = "DRTextBox";
            this.DRTextBox.Size = new System.Drawing.Size(62, 22);
            this.DRTextBox.TabIndex = 11;
            this.DRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DRTextBox.ValueChanged += new System.EventHandler(this.resultButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 44);
            this.label5.TabIndex = 14;
            this.label5.Text = "Длина Рукава:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.84925F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.15075F));
            this.tableLayoutPanel1.Controls.Add(this.OBTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DITextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DRTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.OTTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.OGlabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OGTextBox, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 208);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // OBTextBox
            // 
            this.OBTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OBTextBox.Location = new System.Drawing.Point(183, 6);
            this.OBTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OBTextBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.OBTextBox.Name = "OBTextBox";
            this.OBTextBox.Size = new System.Drawing.Size(62, 22);
            this.OBTextBox.TabIndex = 18;
            this.OBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OBTextBox.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.OBTextBox.ValueChanged += new System.EventHandler(this.resultButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Вы выбрали:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Нужно:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "см.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Izb
            // 
            this.Izb.Location = new System.Drawing.Point(338, 324);
            this.Izb.Name = "Izb";
            this.Izb.Size = new System.Drawing.Size(200, 34);
            this.Izb.TabIndex = 25;
            this.Izb.Text = "Избранное";
            this.Izb.UseVisualStyleBackColor = true;
            this.Izb.Click += new System.EventHandler(this.Izb_Click_1);
            // 
            // PBizb
            // 
            this.PBizb.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Избранное;
            this.PBizb.Image = global::WindowsFormsApp4.Properties.Resources.Избранное;
            this.PBizb.Location = new System.Drawing.Point(418, 36);
            this.PBizb.Name = "PBizb";
            this.PBizb.Size = new System.Drawing.Size(40, 41);
            this.PBizb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBizb.TabIndex = 24;
            this.PBizb.TabStop = false;
            this.PBizb.Click += new System.EventHandler(this.PBizb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 415);
            this.Controls.Add(this.Izb);
            this.Controls.Add(this.PBizb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.Text = "Проект";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OGTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DITextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRTextBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OBTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBizb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown OGTextBox;
        private System.Windows.Forms.NumericUpDown OTTextBox;
        private System.Windows.Forms.NumericUpDown DITextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OGlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DRTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown OBTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PBizb;
        private System.Windows.Forms.Button Izb;
    }
}

