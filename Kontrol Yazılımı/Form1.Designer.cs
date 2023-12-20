namespace Kontrol_Yazılımı
{
    partial class AnaGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kayitBT = new System.Windows.Forms.Button();
            this.AnaGirisLB = new System.Windows.Forms.Label();
            this.musteriGB = new System.Windows.Forms.GroupBox();
            this.musteriLB = new System.Windows.Forms.Label();
            this.musteriCB = new System.Windows.Forms.CheckBox();
            this.isArayanGB = new System.Windows.Forms.GroupBox();
            this.isArayanLB = new System.Windows.Forms.Label();
            this.isArayanCB = new System.Windows.Forms.CheckBox();
            this.AnaGirisLL = new System.Windows.Forms.LinkLabel();
            this.linkLL = new System.Windows.Forms.Label();
            this.musteriGB.SuspendLayout();
            this.isArayanGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitBT
            // 
            this.kayitBT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.kayitBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.kayitBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.kayitBT.Location = new System.Drawing.Point(234, 301);
            this.kayitBT.Name = "kayitBT";
            this.kayitBT.Size = new System.Drawing.Size(326, 47);
            this.kayitBT.TabIndex = 0;
            this.kayitBT.Text = "Kayıt Oluştur";
            this.kayitBT.UseVisualStyleBackColor = false;
            this.kayitBT.Click += new System.EventHandler(this.kayitBT_Click);
            // 
            // AnaGirisLB
            // 
            this.AnaGirisLB.AutoSize = true;
            this.AnaGirisLB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnaGirisLB.Location = new System.Drawing.Point(192, 33);
            this.AnaGirisLB.Name = "AnaGirisLB";
            this.AnaGirisLB.Size = new System.Drawing.Size(399, 46);
            this.AnaGirisLB.TabIndex = 1;
            this.AnaGirisLB.Text = "Kullanıcı Tipini Belirleyiniz";
            // 
            // musteriGB
            // 
            this.musteriGB.BackColor = System.Drawing.Color.Gainsboro;
            this.musteriGB.Controls.Add(this.musteriLB);
            this.musteriGB.Controls.Add(this.musteriCB);
            this.musteriGB.Location = new System.Drawing.Point(101, 122);
            this.musteriGB.Name = "musteriGB";
            this.musteriGB.Size = new System.Drawing.Size(250, 125);
            this.musteriGB.TabIndex = 2;
            this.musteriGB.TabStop = false;
            // 
            // musteriLB
            // 
            this.musteriLB.AutoSize = true;
            this.musteriLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musteriLB.Location = new System.Drawing.Point(63, 49);
            this.musteriLB.Name = "musteriLB";
            this.musteriLB.Size = new System.Drawing.Size(98, 35);
            this.musteriLB.TabIndex = 1;
            this.musteriLB.Text = "Müşteri";
            // 
            // musteriCB
            // 
            this.musteriCB.AutoSize = true;
            this.musteriCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.musteriCB.Location = new System.Drawing.Point(205, 22);
            this.musteriCB.Name = "musteriCB";
            this.musteriCB.Size = new System.Drawing.Size(18, 17);
            this.musteriCB.TabIndex = 0;
            this.musteriCB.UseVisualStyleBackColor = true;
            this.musteriCB.CheckedChanged += new System.EventHandler(this.musteriCB_CheckedChanged);
            // 
            // isArayanGB
            // 
            this.isArayanGB.BackColor = System.Drawing.Color.Gainsboro;
            this.isArayanGB.Controls.Add(this.isArayanLB);
            this.isArayanGB.Controls.Add(this.isArayanCB);
            this.isArayanGB.Location = new System.Drawing.Point(481, 122);
            this.isArayanGB.Name = "isArayanGB";
            this.isArayanGB.Size = new System.Drawing.Size(250, 125);
            this.isArayanGB.TabIndex = 3;
            this.isArayanGB.TabStop = false;
            // 
            // isArayanLB
            // 
            this.isArayanLB.AutoSize = true;
            this.isArayanLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isArayanLB.Location = new System.Drawing.Point(61, 49);
            this.isArayanLB.Name = "isArayanLB";
            this.isArayanLB.Size = new System.Drawing.Size(124, 35);
            this.isArayanLB.TabIndex = 1;
            this.isArayanLB.Text = "İş Arayan ";
            // 
            // isArayanCB
            // 
            this.isArayanCB.AutoSize = true;
            this.isArayanCB.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.isArayanCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.isArayanCB.Location = new System.Drawing.Point(213, 22);
            this.isArayanCB.Name = "isArayanCB";
            this.isArayanCB.Size = new System.Drawing.Size(18, 17);
            this.isArayanCB.TabIndex = 0;
            this.isArayanCB.UseVisualStyleBackColor = true;
            this.isArayanCB.CheckedChanged += new System.EventHandler(this.isArayanCB_CheckedChanged);
            // 
            // AnaGirisLL
            // 
            this.AnaGirisLL.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.AnaGirisLL.AutoSize = true;
            this.AnaGirisLL.LinkColor = System.Drawing.Color.ForestGreen;
            this.AnaGirisLL.Location = new System.Drawing.Point(427, 366);
            this.AnaGirisLL.Name = "AnaGirisLL";
            this.AnaGirisLL.Size = new System.Drawing.Size(66, 20);
            this.AnaGirisLL.TabIndex = 4;
            this.AnaGirisLL.TabStop = true;
            this.AnaGirisLL.Text = "Giriş Yap";
            this.AnaGirisLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AnaGirisLL_LinkClicked);
            // 
            // linkLL
            // 
            this.linkLL.AutoSize = true;
            this.linkLL.Location = new System.Drawing.Point(290, 366);
            this.linkLL.Name = "linkLL";
            this.linkLL.Size = new System.Drawing.Size(131, 20);
            this.linkLL.TabIndex = 5;
            this.linkLL.Text = "Hesabınız Var Mı ?";
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLL);
            this.Controls.Add(this.AnaGirisLL);
            this.Controls.Add(this.isArayanGB);
            this.Controls.Add(this.musteriGB);
            this.Controls.Add(this.AnaGirisLB);
            this.Controls.Add(this.kayitBT);
            this.Name = "AnaGiris";
            this.Text = "Ana Giriş";
            this.musteriGB.ResumeLayout(false);
            this.musteriGB.PerformLayout();
            this.isArayanGB.ResumeLayout(false);
            this.isArayanGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button kayitBT;
        private Label AnaGirisLB;
        private GroupBox musteriGB;
        private Label musteriLB;
        private CheckBox musteriCB;
        private GroupBox isArayanGB;
        private Label isArayanLB;
        private CheckBox isArayanCB;
        private LinkLabel AnaGirisLL;
        private Label linkLL;
    }
}