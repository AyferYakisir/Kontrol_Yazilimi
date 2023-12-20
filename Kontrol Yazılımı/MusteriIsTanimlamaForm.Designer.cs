namespace Kontrol_Yazılımı
{
    partial class MusteriIsTanimlamaForm
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
            this.isTanimlamaPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.isTanimlamaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // isTanimlamaPB
            // 
            this.isTanimlamaPB.Image = global::Kontrol_Yazılımı.Properties.Resources.isEkleme;
            this.isTanimlamaPB.Location = new System.Drawing.Point(724, 21);
            this.isTanimlamaPB.Name = "isTanimlamaPB";
            this.isTanimlamaPB.Size = new System.Drawing.Size(50, 49);
            this.isTanimlamaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isTanimlamaPB.TabIndex = 1;
            this.isTanimlamaPB.TabStop = false;
            this.isTanimlamaPB.Click += new System.EventHandler(this.isTanimlamaPB_Click);
            this.isTanimlamaPB.MouseHover += new System.EventHandler(this.isTanimlamaPB_MouseHover);
            // 
            // MusteriIsTanimlamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isTanimlamaPB);
            this.Name = "MusteriIsTanimlamaForm";
            this.Text = "İş Tanımlama";
            ((System.ComponentModel.ISupportInitialize)(this.isTanimlamaPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox isTanimlamaPB;
    }
}