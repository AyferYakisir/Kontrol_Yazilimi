namespace Kontrol_Yazılımı
{
    partial class isTanimlamaEkrani
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
            isTanimlamaLB = new Label();
            pBaslikLB = new Label();
            pAciklamaLB = new Label();
            pButceLB = new Label();
            pTarih = new Label();
            pBaslikTB = new TextBox();
            pAciklamaRB = new RichTextBox();
            pTarihDTP = new DateTimePicker();
            pButceTB = new TextBox();
            pTanimlaBT = new Button();
            SuspendLayout();
            // 
            // isTanimlamaLB
            // 
            isTanimlamaLB.AutoSize = true;
            isTanimlamaLB.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            isTanimlamaLB.Location = new Point(212, 22);
            isTanimlamaLB.Name = "isTanimlamaLB";
            isTanimlamaLB.Size = new Size(344, 46);
            isTanimlamaLB.TabIndex = 0;
            isTanimlamaLB.Text = "Proje Bilgilerini Giriniz";
            // 
            // pBaslikLB
            // 
            pBaslikLB.AutoSize = true;
            pBaslikLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pBaslikLB.Location = new Point(60, 105);
            pBaslikLB.Name = "pBaslikLB";
            pBaslikLB.Size = new Size(65, 28);
            pBaslikLB.TabIndex = 1;
            pBaslikLB.Text = "Başlık:";
            // 
            // pAciklamaLB
            // 
            pAciklamaLB.AutoSize = true;
            pAciklamaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pAciklamaLB.Location = new Point(361, 102);
            pAciklamaLB.Name = "pAciklamaLB";
            pAciklamaLB.Size = new Size(95, 28);
            pAciklamaLB.TabIndex = 2;
            pAciklamaLB.Text = "Açıklama:";
            // 
            // pButceLB
            // 
            pButceLB.AutoSize = true;
            pButceLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pButceLB.Location = new Point(61, 178);
            pButceLB.Name = "pButceLB";
            pButceLB.Size = new Size(64, 28);
            pButceLB.TabIndex = 3;
            pButceLB.Text = "Bütçe:";
            // 
            // pTarih
            // 
            pTarih.AutoSize = true;
            pTarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pTarih.Location = new Point(60, 262);
            pTarih.Name = "pTarih";
            pTarih.Size = new Size(57, 28);
            pTarih.TabIndex = 4;
            pTarih.Text = "Tarih:";
            // 
            // pBaslikTB
            // 
            pBaslikTB.BackColor = Color.Gainsboro;
            pBaslikTB.Location = new Point(131, 106);
            pBaslikTB.Name = "pBaslikTB";
            pBaslikTB.Size = new Size(191, 27);
            pBaslikTB.TabIndex = 5;
            // 
            // pAciklamaRB
            // 
            pAciklamaRB.BackColor = Color.Gainsboro;
            pAciklamaRB.Location = new Point(489, 102);
            pAciklamaRB.Name = "pAciklamaRB";
            pAciklamaRB.Size = new Size(268, 188);
            pAciklamaRB.TabIndex = 6;
            pAciklamaRB.Text = "";
            // 
            // pTarihDTP
            // 
            pTarihDTP.CalendarTitleBackColor = Color.Gainsboro;
            pTarihDTP.Location = new Point(131, 262);
            pTarihDTP.Name = "pTarihDTP";
            pTarihDTP.Size = new Size(241, 27);
            pTarihDTP.TabIndex = 7;
            // 
            // pButceTB
            // 
            pButceTB.BackColor = Color.Gainsboro;
            pButceTB.Location = new Point(131, 182);
            pButceTB.Name = "pButceTB";
            pButceTB.Size = new Size(191, 27);
            pButceTB.TabIndex = 8;
            // 
            // pTanimlaBT
            // 
            pTanimlaBT.BackColor = Color.DarkSeaGreen;
            pTanimlaBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pTanimlaBT.Location = new Point(323, 353);
            pTanimlaBT.Name = "pTanimlaBT";
            pTanimlaBT.Size = new Size(133, 55);
            pTanimlaBT.TabIndex = 9;
            pTanimlaBT.Text = "Tanımla";
            pTanimlaBT.UseVisualStyleBackColor = false;
            pTanimlaBT.Click += pTanimlaBT_Click;
            // 
            // isTanimlamaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pTanimlaBT);
            Controls.Add(pButceTB);
            Controls.Add(pTarihDTP);
            Controls.Add(pAciklamaRB);
            Controls.Add(pBaslikTB);
            Controls.Add(pTarih);
            Controls.Add(pButceLB);
            Controls.Add(pAciklamaLB);
            Controls.Add(pBaslikLB);
            Controls.Add(isTanimlamaLB);
            Name = "isTanimlamaEkrani";
            Text = "isTanimlamaEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label isTanimlamaLB;
        private Label pBaslikLB;
        private Label pAciklamaLB;
        private Label pButceLB;
        private Label pTarih;
        private TextBox pBaslikTB;
        private RichTextBox pAciklamaRB;
        private DateTimePicker pTarihDTP;
        private TextBox pButceTB;
        private Button pTanimlaBT;
    }
}