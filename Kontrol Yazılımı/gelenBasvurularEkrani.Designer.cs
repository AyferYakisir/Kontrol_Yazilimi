namespace Kontrol_Yazılımı
{
    partial class gelenBasvurularEkrani
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
            basvuruListBox = new ListBox();
            label1 = new Label();
            teklifBT = new Button();
            geriBT = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)geriBT).BeginInit();
            SuspendLayout();
            // 
            // basvuruListBox
            // 
            basvuruListBox.FormattingEnabled = true;
            basvuruListBox.HorizontalScrollbar = true;
            basvuruListBox.ItemHeight = 20;
            basvuruListBox.Location = new Point(105, 83);
            basvuruListBox.Name = "basvuruListBox";
            basvuruListBox.ScrollAlwaysVisible = true;
            basvuruListBox.Size = new Size(531, 324);
            basvuruListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(291, 22);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 1;
            label1.Text = "Başvurular";
            // 
            // teklifBT
            // 
            teklifBT.BackColor = Color.DarkSeaGreen;
            teklifBT.Location = new Point(668, 349);
            teklifBT.Name = "teklifBT";
            teklifBT.Size = new Size(106, 58);
            teklifBT.TabIndex = 2;
            teklifBT.Text = "Teklifi Değerlendir";
            teklifBT.UseVisualStyleBackColor = false;
            teklifBT.Click += teklifBT_Click;
            // 
            // geriBT
            // 
            geriBT.Image = Properties.Resources.geriButonu;
            geriBT.Location = new Point(12, 12);
            geriBT.Name = "geriBT";
            geriBT.Size = new Size(72, 52);
            geriBT.SizeMode = PictureBoxSizeMode.Zoom;
            geriBT.TabIndex = 3;
            geriBT.TabStop = false;
            geriBT.Click += geriBT_Click;
            // 
            // gelenBasvurularEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(geriBT);
            Controls.Add(teklifBT);
            Controls.Add(label1);
            Controls.Add(basvuruListBox);
            Name = "gelenBasvurularEkrani";
            Text = "Gelen Başvurular";
            ((System.ComponentModel.ISupportInitialize)geriBT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox basvuruListBox;
        private Label label1;
        private Button teklifBT;
        private PictureBox geriBT;
    }
}