namespace Kontrol_Yazılımı
{
    partial class TamamlananIsler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamamlananIsler));
            listBoxTamamlananIsler = new ListBox();
            onaylaLB = new Button();
            kontrolEtBtn = new Button();
            odemeBT = new Button();
            geriBT = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)geriBT).BeginInit();
            SuspendLayout();
            // 
            // listBoxTamamlananIsler
            // 
            listBoxTamamlananIsler.FormattingEnabled = true;
            listBoxTamamlananIsler.ItemHeight = 20;
            listBoxTamamlananIsler.Location = new Point(100, 93);
            listBoxTamamlananIsler.Name = "listBoxTamamlananIsler";
            listBoxTamamlananIsler.ScrollAlwaysVisible = true;
            listBoxTamamlananIsler.Size = new Size(422, 264);
            listBoxTamamlananIsler.TabIndex = 0;
            // 
            // onaylaLB
            // 
            onaylaLB.BackColor = Color.DarkSeaGreen;
            onaylaLB.Location = new Point(620, 262);
            onaylaLB.Name = "onaylaLB";
            onaylaLB.Size = new Size(94, 59);
            onaylaLB.TabIndex = 1;
            onaylaLB.Text = "Onayla";
            onaylaLB.UseVisualStyleBackColor = false;
            onaylaLB.Click += onaylaLB_Click;
            // 
            // kontrolEtBtn
            // 
            kontrolEtBtn.BackColor = Color.MediumSeaGreen;
            kontrolEtBtn.Location = new Point(215, 373);
            kontrolEtBtn.Name = "kontrolEtBtn";
            kontrolEtBtn.Size = new Size(181, 49);
            kontrolEtBtn.TabIndex = 2;
            kontrolEtBtn.Text = "Aboneliği Kontrol Et";
            kontrolEtBtn.UseVisualStyleBackColor = false;
            kontrolEtBtn.Click += kontrolEtBtn_Click;
            // 
            // odemeBT
            // 
            odemeBT.BackColor = Color.DarkSeaGreen;
            odemeBT.Location = new Point(620, 156);
            odemeBT.Name = "odemeBT";
            odemeBT.Size = new Size(94, 55);
            odemeBT.TabIndex = 4;
            odemeBT.Text = "Ödeme Yap";
            odemeBT.UseVisualStyleBackColor = false;
            odemeBT.Click += odemeBT_Click;
            // 
            // geriBT
            // 
            geriBT.Image = Properties.Resources.geriButonu;
            geriBT.Location = new Point(21, 12);
            geriBT.Name = "geriBT";
            geriBT.Size = new Size(56, 50);
            geriBT.SizeMode = PictureBoxSizeMode.Zoom;
            geriBT.TabIndex = 5;
            geriBT.TabStop = false;
            geriBT.Click += geriBT_Click_1;
            // 
            // TamamlananIsler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(geriBT);
            Controls.Add(odemeBT);
            Controls.Add(kontrolEtBtn);
            Controls.Add(onaylaLB);
            Controls.Add(listBoxTamamlananIsler);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TamamlananIsler";
            Text = "Tamamlanan Projeler";
            ((System.ComponentModel.ISupportInitialize)geriBT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTamamlananIsler;
        private Button onaylaLB;
        private Button kontrolEtBtn;
        private Button odemeBT;
        private PictureBox geriBT;
    }
}