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
            isAramaGB2 = new GroupBox();
            fiyatLB = new Label();
            fiyatTrB = new TrackBar();
            projeTipiGB = new GroupBox();
            saatlikPLB = new Label();
            sabitPLB = new Label();
            projeTipiLB = new Label();
            isAramaCB1 = new CheckBox();
            isAramaCB2 = new CheckBox();
            isAramaGB1 = new GroupBox();
            isAramaGB2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fiyatTrB).BeginInit();
            projeTipiGB.SuspendLayout();
            SuspendLayout();
            // 
            // isAramaGB2
            // 
            isAramaGB2.BackColor = Color.Gainsboro;
            isAramaGB2.Controls.Add(fiyatLB);
            isAramaGB2.Controls.Add(fiyatTrB);
            isAramaGB2.Controls.Add(projeTipiGB);
            isAramaGB2.Location = new Point(12, 45);
            isAramaGB2.Name = "isAramaGB2";
            isAramaGB2.Size = new Size(143, 396);
            isAramaGB2.TabIndex = 0;
            isAramaGB2.TabStop = false;
            // 
            // fiyatLB
            // 
            fiyatLB.AutoSize = true;
            fiyatLB.Location = new Point(30, 282);
            fiyatLB.Name = "fiyatLB";
            fiyatLB.Size = new Size(68, 20);
            fiyatLB.TabIndex = 3;
            fiyatLB.Text = "Ort. Fiyat";
            // 
            // fiyatTrB
            // 
            fiyatTrB.BackColor = Color.DarkGray;
            fiyatTrB.Location = new Point(6, 319);
            fiyatTrB.Name = "fiyatTrB";
            fiyatTrB.Size = new Size(131, 56);
            fiyatTrB.TabIndex = 2;
            // 
            // projeTipiGB
            // 
            projeTipiGB.BackColor = Color.DarkGray;
            projeTipiGB.Controls.Add(saatlikPLB);
            projeTipiGB.Controls.Add(sabitPLB);
            projeTipiGB.Controls.Add(projeTipiLB);
            projeTipiGB.Controls.Add(isAramaCB1);
            projeTipiGB.Controls.Add(isAramaCB2);
            projeTipiGB.Location = new Point(0, 17);
            projeTipiGB.Name = "projeTipiGB";
            projeTipiGB.Size = new Size(143, 125);
            projeTipiGB.TabIndex = 0;
            projeTipiGB.TabStop = false;
            // 
            // saatlikPLB
            // 
            saatlikPLB.AutoSize = true;
            saatlikPLB.Location = new Point(30, 75);
            saatlikPLB.Name = "saatlikPLB";
            saatlikPLB.Size = new Size(91, 20);
            saatlikPLB.TabIndex = 4;
            saatlikPLB.Text = "Saatlik Proje";
            // 
            // sabitPLB
            // 
            sabitPLB.AutoSize = true;
            sabitPLB.Location = new Point(30, 38);
            sabitPLB.Name = "sabitPLB";
            sabitPLB.Size = new Size(81, 20);
            sabitPLB.TabIndex = 3;
            sabitPLB.Text = "Sabit Proje";
            // 
            // projeTipiLB
            // 
            projeTipiLB.AutoSize = true;
            projeTipiLB.Location = new Point(6, 6);
            projeTipiLB.Name = "projeTipiLB";
            projeTipiLB.Size = new Size(72, 20);
            projeTipiLB.TabIndex = 2;
            projeTipiLB.Text = "Proje Tipi";
            // 
            // isAramaCB1
            // 
            isAramaCB1.AutoSize = true;
            isAramaCB1.Location = new Point(6, 38);
            isAramaCB1.Name = "isAramaCB1";
            isAramaCB1.Size = new Size(18, 17);
            isAramaCB1.TabIndex = 0;
            isAramaCB1.UseVisualStyleBackColor = true;
            // 
            // isAramaCB2
            // 
            isAramaCB2.AutoSize = true;
            isAramaCB2.Location = new Point(6, 78);
            isAramaCB2.Name = "isAramaCB2";
            isAramaCB2.Size = new Size(18, 17);
            isAramaCB2.TabIndex = 1;
            isAramaCB2.UseVisualStyleBackColor = true;
            isAramaCB2.CheckedChanged += isAramaCB2_CheckedChanged;
            // 
            // isAramaGB1
            // 
            isAramaGB1.Location = new Point(12, -2);
            isAramaGB1.Name = "isAramaGB1";
            isAramaGB1.Size = new Size(776, 41);
            isAramaGB1.TabIndex = 1;
            isAramaGB1.TabStop = false;
            // 
            // IsArayanIsAramaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 514);
            Controls.Add(isAramaGB1);
            Controls.Add(isAramaGB2);
            Name = "IsArayanIsAramaForm";
            Text = "İş Arama";
            isAramaGB2.ResumeLayout(false);
            isAramaGB2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fiyatTrB).EndInit();
            projeTipiGB.ResumeLayout(false);
            projeTipiGB.PerformLayout();
            ResumeLayout(false);
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