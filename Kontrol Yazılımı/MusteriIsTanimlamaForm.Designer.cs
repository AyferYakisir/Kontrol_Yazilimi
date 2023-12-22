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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriIsTanimlamaForm));
            isTanimlamaPB = new PictureBox();
            GB1 = new GroupBox();
            tarihTB1 = new TextBox();
            butceTB1 = new TextBox();
            aciklamaRB1 = new RichTextBox();
            baslikTB1 = new TextBox();
            aciklamaLB = new Label();
            tarihLB = new Label();
            bütceLB = new Label();
            pBaslikLB = new Label();
            PB1 = new PictureBox();
            vScrollBar1 = new VScrollBar();
            GB2 = new GroupBox();
            PB2 = new PictureBox();
            aciklamaRB2 = new RichTextBox();
            tarihTB2 = new TextBox();
            butceTB2 = new TextBox();
            baslikTB2 = new TextBox();
            aciklamaLB2 = new Label();
            tarihLB2 = new Label();
            butceLB2 = new Label();
            baslikLB2 = new Label();
            GB3 = new GroupBox();
            PB3 = new PictureBox();
            aciklamaRB3 = new RichTextBox();
            tarihTB3 = new TextBox();
            butceTB3 = new TextBox();
            baslikTB3 = new TextBox();
            aciklamaLB3 = new Label();
            tarihLB3 = new Label();
            butceLB3 = new Label();
            baslikLB3 = new Label();
            ((System.ComponentModel.ISupportInitialize)isTanimlamaPB).BeginInit();
            GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB1).BeginInit();
            GB2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB2).BeginInit();
            GB3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB3).BeginInit();
            SuspendLayout();
            // 
            // isTanimlamaPB
            // 
            isTanimlamaPB.Image = Properties.Resources.isEkleme;
            isTanimlamaPB.Location = new Point(724, 21);
            isTanimlamaPB.Name = "isTanimlamaPB";
            isTanimlamaPB.Size = new Size(50, 49);
            isTanimlamaPB.SizeMode = PictureBoxSizeMode.Zoom;
            isTanimlamaPB.TabIndex = 1;
            isTanimlamaPB.TabStop = false;
            isTanimlamaPB.Click += isTanimlamaPB_Click;
            isTanimlamaPB.MouseHover += isTanimlamaPB_MouseHover;
            // 
            // GB1
            // 
            GB1.Controls.Add(tarihTB1);
            GB1.Controls.Add(butceTB1);
            GB1.Controls.Add(aciklamaRB1);
            GB1.Controls.Add(baslikTB1);
            GB1.Controls.Add(aciklamaLB);
            GB1.Controls.Add(tarihLB);
            GB1.Controls.Add(bütceLB);
            GB1.Controls.Add(pBaslikLB);
            GB1.Controls.Add(PB1);
            GB1.Location = new Point(56, 21);
            GB1.Name = "GB1";
            GB1.Size = new Size(617, 129);
            GB1.TabIndex = 3;
            GB1.TabStop = false;
            GB1.Enter += GB1_Enter;
            // 
            // tarihTB1
            // 
            tarihTB1.BackColor = Color.Gainsboro;
            tarihTB1.Location = new Point(87, 90);
            tarihTB1.Name = "tarihTB1";
            tarihTB1.Size = new Size(155, 27);
            tarihTB1.TabIndex = 10;
            tarihTB1.TextChanged += tarihTB1_TextChanged;
            // 
            // butceTB1
            // 
            butceTB1.BackColor = Color.Gainsboro;
            butceTB1.Location = new Point(87, 57);
            butceTB1.Name = "butceTB1";
            butceTB1.Size = new Size(155, 27);
            butceTB1.TabIndex = 9;
            butceTB1.TextChanged += butceTB1_TextChanged;
            // 
            // aciklamaRB1
            // 
            aciklamaRB1.BackColor = Color.Gainsboro;
            aciklamaRB1.Location = new Point(374, 26);
            aciklamaRB1.Name = "aciklamaRB1";
            aciklamaRB1.ReadOnly = true;
            aciklamaRB1.Size = new Size(185, 92);
            aciklamaRB1.TabIndex = 8;
            aciklamaRB1.Text = "";
            aciklamaRB1.TextChanged += aciklamaRB1_TextChanged;
            // 
            // baslikTB1
            // 
            baslikTB1.BackColor = Color.Gainsboro;
            baslikTB1.Location = new Point(87, 24);
            baslikTB1.Name = "baslikTB1";
            baslikTB1.ReadOnly = true;
            baslikTB1.Size = new Size(155, 27);
            baslikTB1.TabIndex = 5;
            baslikTB1.TextChanged += baslikTB1_TextChanged;
            // 
            // aciklamaLB
            // 
            aciklamaLB.AutoSize = true;
            aciklamaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aciklamaLB.Location = new Point(273, 25);
            aciklamaLB.Name = "aciklamaLB";
            aciklamaLB.Size = new Size(95, 28);
            aciklamaLB.TabIndex = 4;
            aciklamaLB.Text = "Açıklama:";
            // 
            // tarihLB
            // 
            tarihLB.AutoSize = true;
            tarihLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tarihLB.Location = new Point(6, 90);
            tarihLB.Name = "tarihLB";
            tarihLB.Size = new Size(57, 28);
            tarihLB.TabIndex = 3;
            tarihLB.Text = "Tarih:";
            // 
            // bütceLB
            // 
            bütceLB.AutoSize = true;
            bütceLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bütceLB.Location = new Point(6, 56);
            bütceLB.Name = "bütceLB";
            bütceLB.Size = new Size(64, 28);
            bütceLB.TabIndex = 2;
            bütceLB.Text = "Bütçe:";
            // 
            // pBaslikLB
            // 
            pBaslikLB.AutoSize = true;
            pBaslikLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pBaslikLB.Location = new Point(5, 26);
            pBaslikLB.Name = "pBaslikLB";
            pBaslikLB.Size = new Size(65, 28);
            pBaslikLB.TabIndex = 1;
            pBaslikLB.Text = "Başlık:";
            // 
            // PB1
            // 
            PB1.Image = (Image)resources.GetObject("PB1.Image");
            PB1.Location = new Point(565, 26);
            PB1.Name = "PB1";
            PB1.Size = new Size(46, 38);
            PB1.SizeMode = PictureBoxSizeMode.Zoom;
            PB1.TabIndex = 0;
            PB1.TabStop = false;
            PB1.Click += PB1_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(9, 21);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 521);
            vScrollBar1.TabIndex = 6;
            // 
            // GB2
            // 
            GB2.Controls.Add(PB2);
            GB2.Controls.Add(aciklamaRB2);
            GB2.Controls.Add(tarihTB2);
            GB2.Controls.Add(butceTB2);
            GB2.Controls.Add(baslikTB2);
            GB2.Controls.Add(aciklamaLB2);
            GB2.Controls.Add(tarihLB2);
            GB2.Controls.Add(butceLB2);
            GB2.Controls.Add(baslikLB2);
            GB2.Location = new Point(56, 169);
            GB2.Name = "GB2";
            GB2.Size = new Size(617, 129);
            GB2.TabIndex = 7;
            GB2.TabStop = false;
            GB2.Enter += GB2_Enter;
            // 
            // PB2
            // 
            PB2.Image = (Image)resources.GetObject("PB2.Image");
            PB2.Location = new Point(565, 25);
            PB2.Name = "PB2";
            PB2.Size = new Size(46, 38);
            PB2.SizeMode = PictureBoxSizeMode.Zoom;
            PB2.TabIndex = 9;
            PB2.TabStop = false;
            // 
            // aciklamaRB2
            // 
            aciklamaRB2.BackColor = Color.Gainsboro;
            aciklamaRB2.Location = new Point(374, 26);
            aciklamaRB2.Name = "aciklamaRB2";
            aciklamaRB2.ReadOnly = true;
            aciklamaRB2.Size = new Size(185, 92);
            aciklamaRB2.TabIndex = 8;
            aciklamaRB2.Text = "";
            // 
            // tarihTB2
            // 
            tarihTB2.BackColor = Color.Gainsboro;
            tarihTB2.Location = new Point(87, 90);
            tarihTB2.Name = "tarihTB2";
            tarihTB2.Size = new Size(155, 27);
            tarihTB2.TabIndex = 7;
            // 
            // butceTB2
            // 
            butceTB2.BackColor = Color.Gainsboro;
            butceTB2.Location = new Point(87, 57);
            butceTB2.Name = "butceTB2";
            butceTB2.Size = new Size(155, 27);
            butceTB2.TabIndex = 6;
            // 
            // baslikTB2
            // 
            baslikTB2.BackColor = Color.Gainsboro;
            baslikTB2.Location = new Point(87, 24);
            baslikTB2.Name = "baslikTB2";
            baslikTB2.Size = new Size(155, 27);
            baslikTB2.TabIndex = 5;
            // 
            // aciklamaLB2
            // 
            aciklamaLB2.AutoSize = true;
            aciklamaLB2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aciklamaLB2.Location = new Point(273, 25);
            aciklamaLB2.Name = "aciklamaLB2";
            aciklamaLB2.Size = new Size(95, 28);
            aciklamaLB2.TabIndex = 4;
            aciklamaLB2.Text = "Açıklama:";
            // 
            // tarihLB2
            // 
            tarihLB2.AutoSize = true;
            tarihLB2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tarihLB2.Location = new Point(10, 86);
            tarihLB2.Name = "tarihLB2";
            tarihLB2.Size = new Size(57, 28);
            tarihLB2.TabIndex = 3;
            tarihLB2.Text = "Tarih:";
            // 
            // butceLB2
            // 
            butceLB2.AutoSize = true;
            butceLB2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            butceLB2.Location = new Point(6, 58);
            butceLB2.Name = "butceLB2";
            butceLB2.Size = new Size(64, 28);
            butceLB2.TabIndex = 2;
            butceLB2.Text = "Bütçe:";
            // 
            // baslikLB2
            // 
            baslikLB2.AutoSize = true;
            baslikLB2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baslikLB2.Location = new Point(9, 23);
            baslikLB2.Name = "baslikLB2";
            baslikLB2.Size = new Size(65, 28);
            baslikLB2.TabIndex = 1;
            baslikLB2.Text = "Başlık:";
            // 
            // GB3
            // 
            GB3.Controls.Add(PB3);
            GB3.Controls.Add(aciklamaRB3);
            GB3.Controls.Add(tarihTB3);
            GB3.Controls.Add(butceTB3);
            GB3.Controls.Add(baslikTB3);
            GB3.Controls.Add(aciklamaLB3);
            GB3.Controls.Add(tarihLB3);
            GB3.Controls.Add(butceLB3);
            GB3.Controls.Add(baslikLB3);
            GB3.Location = new Point(56, 317);
            GB3.Name = "GB3";
            GB3.Size = new Size(617, 129);
            GB3.TabIndex = 8;
            GB3.TabStop = false;
            GB3.Enter += GB3_Enter;
            // 
            // PB3
            // 
            PB3.Image = (Image)resources.GetObject("PB3.Image");
            PB3.Location = new Point(565, 23);
            PB3.Name = "PB3";
            PB3.Size = new Size(46, 38);
            PB3.SizeMode = PictureBoxSizeMode.Zoom;
            PB3.TabIndex = 9;
            PB3.TabStop = false;
            // 
            // aciklamaRB3
            // 
            aciklamaRB3.BackColor = Color.Gainsboro;
            aciklamaRB3.Location = new Point(374, 26);
            aciklamaRB3.Name = "aciklamaRB3";
            aciklamaRB3.ReadOnly = true;
            aciklamaRB3.Size = new Size(185, 92);
            aciklamaRB3.TabIndex = 8;
            aciklamaRB3.Text = "";
            // 
            // tarihTB3
            // 
            tarihTB3.BackColor = Color.Gainsboro;
            tarihTB3.Location = new Point(87, 90);
            tarihTB3.Name = "tarihTB3";
            tarihTB3.Size = new Size(155, 27);
            tarihTB3.TabIndex = 7;
            // 
            // butceTB3
            // 
            butceTB3.BackColor = Color.Gainsboro;
            butceTB3.Location = new Point(87, 57);
            butceTB3.Name = "butceTB3";
            butceTB3.Size = new Size(155, 27);
            butceTB3.TabIndex = 6;
            // 
            // baslikTB3
            // 
            baslikTB3.BackColor = Color.Gainsboro;
            baslikTB3.Location = new Point(87, 24);
            baslikTB3.Name = "baslikTB3";
            baslikTB3.Size = new Size(155, 27);
            baslikTB3.TabIndex = 5;
            // 
            // aciklamaLB3
            // 
            aciklamaLB3.AutoSize = true;
            aciklamaLB3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aciklamaLB3.Location = new Point(273, 25);
            aciklamaLB3.Name = "aciklamaLB3";
            aciklamaLB3.Size = new Size(95, 28);
            aciklamaLB3.TabIndex = 4;
            aciklamaLB3.Text = "Açıklama:";
            // 
            // tarihLB3
            // 
            tarihLB3.AutoSize = true;
            tarihLB3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tarihLB3.Location = new Point(10, 79);
            tarihLB3.Name = "tarihLB3";
            tarihLB3.Size = new Size(57, 28);
            tarihLB3.TabIndex = 3;
            tarihLB3.Text = "Tarih:";
            // 
            // butceLB3
            // 
            butceLB3.AutoSize = true;
            butceLB3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            butceLB3.Location = new Point(10, 51);
            butceLB3.Name = "butceLB3";
            butceLB3.Size = new Size(64, 28);
            butceLB3.TabIndex = 2;
            butceLB3.Text = "Bütçe:";
            // 
            // baslikLB3
            // 
            baslikLB3.AutoSize = true;
            baslikLB3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baslikLB3.Location = new Point(9, 23);
            baslikLB3.Name = "baslikLB3";
            baslikLB3.Size = new Size(65, 28);
            baslikLB3.TabIndex = 1;
            baslikLB3.Text = "Başlık:";
            // 
            // MusteriIsTanimlamaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(GB3);
            Controls.Add(GB2);
            Controls.Add(vScrollBar1);
            Controls.Add(GB1);
            Controls.Add(isTanimlamaPB);
            Name = "MusteriIsTanimlamaForm";
            Text = "İş Tanımlama";
            ((System.ComponentModel.ISupportInitialize)isTanimlamaPB).EndInit();
            GB1.ResumeLayout(false);
            GB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB1).EndInit();
            GB2.ResumeLayout(false);
            GB2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB2).EndInit();
            GB3.ResumeLayout(false);
            GB3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox isTanimlamaPB;
        private GroupBox GB1;
        private VScrollBar vScrollBar1;
        private PictureBox PB1;
        private PictureBox PB2;
        private PictureBox PB3;
        private PictureBox PB4;
        private Label aciklamaLB;
        private Label tarihLB;
        private Label bütceLB;
        private Label pBaslikLB;
        private TextBox textBox2;
        private GroupBox GB2;
        private Label aciklamaLB2;
        private Label tarihLB2;
        private Label butceLB2;
        private Label baslikLB2;
 
        private GroupBox GB3;
        private Label aciklamaLB3;
        private Label tarihLB3;
        private Label butceLB3;
        private Label baslikLB3;
        private TextBox tarihTB1;
        private TextBox butceTB1;
        private RichTextBox aciklamaRB1;
        private TextBox baslikTB1;
        private RichTextBox aciklamaRB2;
        private TextBox tarihTB2;
        private TextBox butceTB2;
        private TextBox baslikTB2;
        private RichTextBox aciklamaRB3;
        private TextBox tarihTB3;
        private TextBox butceTB3;
        private TextBox baslikTB3;
    }
}