﻿namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.resultButton = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.OBTextBox = new System.Windows.Forms.NumericUpDown();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Izb = new System.Windows.Forms.Button();
            this.PBizb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьПромокодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OGTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DITextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRTextBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OBTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBizb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.Location = new System.Drawing.Point(17, 319);
            this.resultButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(196, 39);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "Показать результат";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // OGTextBox
            // 
            this.OGTextBox.Location = new System.Drawing.Point(183, 45);
            this.OGTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OGTextBox.Name = "OGTextBox";
            this.OGTextBox.Size = new System.Drawing.Size(62, 26);
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
            this.OTTextBox.Location = new System.Drawing.Point(183, 84);
            this.OTTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OTTextBox.Name = "OTTextBox";
            this.OTTextBox.Size = new System.Drawing.Size(62, 26);
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
            this.DITextBox.Location = new System.Drawing.Point(183, 123);
            this.DITextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DITextBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.DITextBox.Name = "DITextBox";
            this.DITextBox.Size = new System.Drawing.Size(62, 26);
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
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Обхват Бёдер:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OGlabel
            // 
            this.OGlabel.AutoSize = true;
            this.OGlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OGlabel.Location = new System.Drawing.Point(7, 39);
            this.OGlabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.OGlabel.Name = "OGlabel";
            this.OGlabel.Size = new System.Drawing.Size(162, 39);
            this.OGlabel.TabIndex = 8;
            this.OGlabel.Text = "Охват Груди:";
            this.OGlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Обхват Талии";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Длина Изделия:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DRTextBox
            // 
            this.DRTextBox.Location = new System.Drawing.Point(183, 162);
            this.DRTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DRTextBox.Name = "DRTextBox";
            this.DRTextBox.Size = new System.Drawing.Size(62, 26);
            this.DRTextBox.TabIndex = 11;
            this.DRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DRTextBox.ValueChanged += new System.EventHandler(this.resultButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Длина Рукава:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.84925F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.15075F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
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
            this.tableLayoutPanel1.Controls.Add(this.materialComboBox, 1, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 67);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 237);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(7, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 42);
            this.label2.TabIndex = 19;
            this.label2.Text = "Длина Рукава:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.OBTextBox.Size = new System.Drawing.Size(62, 26);
            this.OBTextBox.TabIndex = 18;
            this.OBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OBTextBox.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.OBTextBox.ValueChanged += new System.EventHandler(this.resultButton_Click);
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Items.AddRange(new object[] {
            "Ткань",
            "Шерсть",
            "Трикотаж",
            "Проволока",
            "Стретч-пленка",
            "Кольчуга"});
            this.materialComboBox.Location = new System.Drawing.Point(179, 198);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(70, 26);
            this.materialComboBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 9;
            // 
            // label12
            // 
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
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Нужно:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 32);
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
            this.PBizb.Location = new System.Drawing.Point(414, 36);
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
            this.pictureBox1.Location = new System.Drawing.Point(338, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "label8";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьПромокодToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // показатьПромокодToolStripMenuItem
            // 
            this.показатьПромокодToolStripMenuItem.Name = "показатьПромокодToolStripMenuItem";
            this.показатьПромокодToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.показатьПромокодToolStripMenuItem.Text = "Показать промокод";
            this.показатьПромокодToolStripMenuItem.Click += new System.EventHandler(this.показатьПромокодToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 32);
            this.label10.TabIndex = 30;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 415);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
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
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resultButton;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьПромокодToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer2;
    }
}

