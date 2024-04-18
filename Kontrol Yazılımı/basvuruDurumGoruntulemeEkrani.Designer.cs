namespace Kontrol_Yazılımı
{
    partial class basvuruDurumGoruntulemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basvuruDurumGoruntulemeEkrani));
            geriPB = new PictureBox();
            basvuruLB = new ListBox();
            isiYapBT = new Button();
            ((System.ComponentModel.ISupportInitialize)geriPB).BeginInit();
            SuspendLayout();
            // 
            // geriPB
            // 
            geriPB.Image = Properties.Resources.geriButonu;
            geriPB.Location = new Point(12, 12);
            geriPB.Name = "geriPB";
            geriPB.Size = new Size(67, 58);
            geriPB.SizeMode = PictureBoxSizeMode.Zoom;
            geriPB.TabIndex = 0;
            geriPB.TabStop = false;
            geriPB.Click += geriPB_Click_1;
            // 
            // basvuruLB
            // 
            basvuruLB.FormattingEnabled = true;
            basvuruLB.HorizontalScrollbar = true;
            basvuruLB.ItemHeight = 20;
            basvuruLB.Location = new Point(116, 71);
            basvuruLB.Name = "basvuruLB";
            basvuruLB.ScrollAlwaysVisible = true;
            basvuruLB.Size = new Size(495, 304);
            basvuruLB.TabIndex = 1;
            basvuruLB.SelectedIndexChanged += basvuruLB_SelectedIndexChanged;
            // 
            // isiYapBT
            // 
            isiYapBT.BackColor = Color.DarkSeaGreen;
            isiYapBT.Location = new Point(661, 335);
            isiYapBT.Name = "isiYapBT";
            isiYapBT.Size = new Size(94, 40);
            isiYapBT.TabIndex = 2;
            isiYapBT.Text = "İşi Yap";
            isiYapBT.UseVisualStyleBackColor = false;
            isiYapBT.Click += isiYapBT_Click;
            // 
            // basvuruDurumGoruntulemeEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(isiYapBT);
            Controls.Add(basvuruLB);
            Controls.Add(geriPB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "basvuruDurumGoruntulemeEkrani";
            Text = "Başvuru Durumları";
            ((System.ComponentModel.ISupportInitialize)geriPB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox geriPB;
        private ListBox basvuruLB;
        private Button isiYapBT;
    }
}