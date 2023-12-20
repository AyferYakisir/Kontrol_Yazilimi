namespace Kontrol_Yazılımı
{
    partial class GirisForm
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
            this.girisLB = new System.Windows.Forms.Label();
            this.gEpostaLB = new System.Windows.Forms.Label();
            this.gSifreLB = new System.Windows.Forms.Label();
            this.gEpostaTB = new System.Windows.Forms.TextBox();
            this.gSifreTB = new System.Windows.Forms.TextBox();
            this.girisBT = new System.Windows.Forms.Button();
            this.girisLL = new System.Windows.Forms.LinkLabel();
            this.linkLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girisLB
            // 
            this.girisLB.AutoSize = true;
            this.girisLB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.girisLB.Location = new System.Drawing.Point(286, 20);
            this.girisLB.Name = "girisLB";
            this.girisLB.Size = new System.Drawing.Size(184, 46);
            this.girisLB.TabIndex = 0;
            this.girisLB.Text = "Giriş Ekranı";
            // 
            // gEpostaLB
            // 
            this.gEpostaLB.AutoSize = true;
            this.gEpostaLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gEpostaLB.Location = new System.Drawing.Point(174, 103);
            this.gEpostaLB.Name = "gEpostaLB";
            this.gEpostaLB.Size = new System.Drawing.Size(81, 28);
            this.gEpostaLB.TabIndex = 1;
            this.gEpostaLB.Text = "E-Posta:";
            // 
            // gSifreLB
            // 
            this.gSifreLB.AutoSize = true;
            this.gSifreLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gSifreLB.Location = new System.Drawing.Point(174, 191);
            this.gSifreLB.Name = "gSifreLB";
            this.gSifreLB.Size = new System.Drawing.Size(55, 28);
            this.gSifreLB.TabIndex = 2;
            this.gSifreLB.Text = "Şifre:";
            // 
            // gEpostaTB
            // 
            this.gEpostaTB.BackColor = System.Drawing.Color.Gainsboro;
            this.gEpostaTB.Location = new System.Drawing.Point(174, 134);
            this.gEpostaTB.Name = "gEpostaTB";
            this.gEpostaTB.Size = new System.Drawing.Size(435, 27);
            this.gEpostaTB.TabIndex = 3;
            // 
            // gSifreTB
            // 
            this.gSifreTB.BackColor = System.Drawing.Color.Gainsboro;
            this.gSifreTB.Location = new System.Drawing.Point(174, 222);
            this.gSifreTB.Name = "gSifreTB";
            this.gSifreTB.Size = new System.Drawing.Size(435, 27);
            this.gSifreTB.TabIndex = 4;
            // 
            // girisBT
            // 
            this.girisBT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.girisBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.girisBT.Location = new System.Drawing.Point(237, 301);
            this.girisBT.Name = "girisBT";
            this.girisBT.Size = new System.Drawing.Size(281, 47);
            this.girisBT.TabIndex = 5;
            this.girisBT.Text = "Giriş";
            this.girisBT.UseVisualStyleBackColor = false;
            this.girisBT.Click += new System.EventHandler(this.girisBT_Click);
            // 
            // girisLL
            // 
            this.girisLL.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.girisLL.AutoSize = true;
            this.girisLL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.girisLL.LinkColor = System.Drawing.Color.ForestGreen;
            this.girisLL.Location = new System.Drawing.Point(380, 381);
            this.girisLL.Name = "girisLL";
            this.girisLL.Size = new System.Drawing.Size(138, 23);
            this.girisLL.TabIndex = 6;
            this.girisLL.TabStop = true;
            this.girisLL.Text = "Hesap Oluşturun";
            this.girisLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.girisLL_LinkClicked);
            // 
            // linkLB
            // 
            this.linkLB.AutoSize = true;
            this.linkLB.Location = new System.Drawing.Point(237, 384);
            this.linkLB.Name = "linkLB";
            this.linkLB.Size = new System.Drawing.Size(137, 20);
            this.linkLB.TabIndex = 7;
            this.linkLB.Text = "Hesabınız Yok Mu ?";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLB);
            this.Controls.Add(this.girisLL);
            this.Controls.Add(this.girisBT);
            this.Controls.Add(this.gSifreTB);
            this.Controls.Add(this.gEpostaTB);
            this.Controls.Add(this.gSifreLB);
            this.Controls.Add(this.gEpostaLB);
            this.Controls.Add(this.girisLB);
            this.Name = "GirisForm";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label girisLB;
        private Label gEpostaLB;
        private Label gSifreLB;
        private TextBox gEpostaTB;
        private TextBox gSifreTB;
        private Button girisBT;
        private LinkLabel girisLL;
        private Label linkLB;
    }
}