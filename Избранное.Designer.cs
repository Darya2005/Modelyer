namespace WindowsFormsApp4
{
    partial class Избранное
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
            this.ZakazB = new System.Windows.Forms.Button();
            this.SuspendLayout();
                   // ZakazB
            // 
            this.ZakazB.Location = new System.Drawing.Point(637, 12);
            this.ZakazB.Name = "ZakazB";
            this.ZakazB.Size = new System.Drawing.Size(140, 30);
            this.ZakazB.TabIndex = 1;
            this.ZakazB.Text = "Сделать заказ";
            this.ZakazB.UseVisualStyleBackColor = true;
            this.ZakazB.Click += new System.EventHandler(this.ZakazB_Click);
            // 
            // Избранное
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 554);
            this.Controls.Add(this.ZakazB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Избранное";
            this.Text = "Избранное";
            this.Load += new System.EventHandler(this.Избранное_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ZakazB;
    }
}