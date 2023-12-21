namespace Kontrol_Yazılımı
{
    partial class IsArayanIsAramaForm
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
            this.isAramaGB2 = new System.Windows.Forms.GroupBox();
            this.isAramaGB1 = new System.Windows.Forms.GroupBox();
            this.isAramaCB1 = new System.Windows.Forms.CheckBox();
            this.isAramaCB2 = new System.Windows.Forms.CheckBox();
            this.projeTipiLB = new System.Windows.Forms.Label();
            this.sabitPLB = new System.Windows.Forms.Label();
            this.saatlikPLB = new System.Windows.Forms.Label();
            this.projeTipiGB = new System.Windows.Forms.GroupBox();
            this.fiyatTrB = new System.Windows.Forms.TrackBar();
            this.fiyatLB = new System.Windows.Forms.Label();
            this.isAramaGB2.SuspendLayout();
            this.projeTipiGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatTrB)).BeginInit();
            this.SuspendLayout();
            // 
            // isAramaGB2
            // 
            this.isAramaGB2.BackColor = System.Drawing.Color.Gainsboro;
            this.isAramaGB2.Controls.Add(this.fiyatLB);
            this.isAramaGB2.Controls.Add(this.fiyatTrB);
            this.isAramaGB2.Controls.Add(this.projeTipiGB);
            this.isAramaGB2.Location = new System.Drawing.Point(12, 45);
            this.isAramaGB2.Name = "isAramaGB2";
            this.isAramaGB2.Size = new System.Drawing.Size(143, 396);
            this.isAramaGB2.TabIndex = 0;
            this.isAramaGB2.TabStop = false;
            // 
            // isAramaGB1
            // 
            this.isAramaGB1.Location = new System.Drawing.Point(12, -2);
            this.isAramaGB1.Name = "isAramaGB1";
            this.isAramaGB1.Size = new System.Drawing.Size(776, 41);
            this.isAramaGB1.TabIndex = 1;
            this.isAramaGB1.TabStop = false;
            // 
            // isAramaCB1
            // 
            this.isAramaCB1.AutoSize = true;
            this.isAramaCB1.Location = new System.Drawing.Point(6, 38);
            this.isAramaCB1.Name = "isAramaCB1";
            this.isAramaCB1.Size = new System.Drawing.Size(18, 17);
            this.isAramaCB1.TabIndex = 0;
            this.isAramaCB1.UseVisualStyleBackColor = true;
            // 
            // isAramaCB2
            // 
            this.isAramaCB2.AutoSize = true;
            this.isAramaCB2.Location = new System.Drawing.Point(6, 78);
            this.isAramaCB2.Name = "isAramaCB2";
            this.isAramaCB2.Size = new System.Drawing.Size(18, 17);
            this.isAramaCB2.TabIndex = 1;
            this.isAramaCB2.UseVisualStyleBackColor = true;
            // 
            // projeTipiLB
            // 
            this.projeTipiLB.AutoSize = true;
            this.projeTipiLB.Location = new System.Drawing.Point(6, 6);
            this.projeTipiLB.Name = "projeTipiLB";
            this.projeTipiLB.Size = new System.Drawing.Size(72, 20);
            this.projeTipiLB.TabIndex = 2;
            this.projeTipiLB.Text = "Proje Tipi";
            // 
            // sabitPLB
            // 
            this.sabitPLB.AutoSize = true;
            this.sabitPLB.Location = new System.Drawing.Point(30, 38);
            this.sabitPLB.Name = "sabitPLB";
            this.sabitPLB.Size = new System.Drawing.Size(81, 20);
            this.sabitPLB.TabIndex = 3;
            this.sabitPLB.Text = "Sabit Proje";
            // 
            // saatlikPLB
            // 
            this.saatlikPLB.AutoSize = true;
            this.saatlikPLB.Location = new System.Drawing.Point(30, 75);
            this.saatlikPLB.Name = "saatlikPLB";
            this.saatlikPLB.Size = new System.Drawing.Size(91, 20);
            this.saatlikPLB.TabIndex = 4;
            this.saatlikPLB.Text = "Saatlik Proje";
            // 
            // projeTipiGB
            // 
            this.projeTipiGB.BackColor = System.Drawing.Color.DarkGray;
            this.projeTipiGB.Controls.Add(this.saatlikPLB);
            this.projeTipiGB.Controls.Add(this.sabitPLB);
            this.projeTipiGB.Controls.Add(this.projeTipiLB);
            this.projeTipiGB.Controls.Add(this.isAramaCB1);
            this.projeTipiGB.Controls.Add(this.isAramaCB2);
            this.projeTipiGB.Location = new System.Drawing.Point(0, 17);
            this.projeTipiGB.Name = "projeTipiGB";
            this.projeTipiGB.Size = new System.Drawing.Size(143, 125);
            this.projeTipiGB.TabIndex = 0;
            this.projeTipiGB.TabStop = false;
            // 
            // fiyatTrB
            // 
            this.fiyatTrB.BackColor = System.Drawing.Color.DarkGray;
            this.fiyatTrB.Location = new System.Drawing.Point(6, 319);
            this.fiyatTrB.Name = "fiyatTrB";
            this.fiyatTrB.Size = new System.Drawing.Size(131, 56);
            this.fiyatTrB.TabIndex = 2;
            // 
            // fiyatLB
            // 
            this.fiyatLB.AutoSize = true;
            this.fiyatLB.Location = new System.Drawing.Point(30, 282);
            this.fiyatLB.Name = "fiyatLB";
            this.fiyatLB.Size = new System.Drawing.Size(68, 20);
            this.fiyatLB.TabIndex = 3;
            this.fiyatLB.Text = "Ort. Fiyat";
            // 
            // IsArayanIsAramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.isAramaGB1);
            this.Controls.Add(this.isAramaGB2);
            this.Name = "IsArayanIsAramaForm";
            this.Text = "İş Arama";
            this.isAramaGB2.ResumeLayout(false);
            this.isAramaGB2.PerformLayout();
            this.projeTipiGB.ResumeLayout(false);
            this.projeTipiGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatTrB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox isAramaGB2;
        private GroupBox isAramaGB1;
        private Label fiyatLB;
        private TrackBar fiyatTrB;
        private GroupBox projeTipiGB;
        private Label saatlikPLB;
        private Label sabitPLB;
        private Label projeTipiLB;
        private CheckBox isAramaCB1;
        private CheckBox isAramaCB2;
    }
}