namespace Kontrol_Yazılımı
{
    partial class isBitimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isBitimi));
            isBitimiLB1 = new Label();
            isBitimiLB2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            projeSureciRB = new RichTextBox();
            gonderBT = new Button();
            comboBoxProjeler = new ComboBox();
            projeLB = new Label();
            SuspendLayout();
            // 
            // isBitimiLB1
            // 
            isBitimiLB1.AutoSize = true;
            isBitimiLB1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isBitimiLB1.Location = new Point(102, 97);
            isBitimiLB1.Name = "isBitimiLB1";
            isBitimiLB1.Size = new Size(119, 28);
            isBitimiLB1.TabIndex = 0;
            isBitimiLB1.Text = "Proje Süreci:";
            // 
            // isBitimiLB2
            // 
            isBitimiLB2.AutoSize = true;
            isBitimiLB2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isBitimiLB2.Location = new Point(118, 296);
            isBitimiLB2.Name = "isBitimiLB2";
            isBitimiLB2.Size = new Size(103, 28);
            isBitimiLB2.TabIndex = 1;
            isBitimiLB2.Text = "Bitiş Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(252, 298);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // projeSureciRB
            // 
            projeSureciRB.BackColor = Color.Gainsboro;
            projeSureciRB.Location = new Point(252, 97);
            projeSureciRB.Name = "projeSureciRB";
            projeSureciRB.Size = new Size(257, 163);
            projeSureciRB.TabIndex = 3;
            projeSureciRB.Text = "";
            // 
            // gonderBT
            // 
            gonderBT.BackColor = Color.DarkSeaGreen;
            gonderBT.Location = new Point(647, 349);
            gonderBT.Name = "gonderBT";
            gonderBT.Size = new Size(94, 54);
            gonderBT.TabIndex = 4;
            gonderBT.Text = "Gönder";
            gonderBT.UseVisualStyleBackColor = false;
            gonderBT.Click += gonderBT_Click;
            // 
            // comboBoxProjeler
            // 
            comboBoxProjeler.BackColor = Color.Gainsboro;
            comboBoxProjeler.FormattingEnabled = true;
            comboBoxProjeler.Location = new Point(252, 38);
            comboBoxProjeler.Name = "comboBoxProjeler";
            comboBoxProjeler.Size = new Size(257, 28);
            comboBoxProjeler.TabIndex = 5;
            // 
            // projeLB
            // 
            projeLB.AutoSize = true;
            projeLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            projeLB.Location = new Point(102, 38);
            projeLB.Name = "projeLB";
            projeLB.Size = new Size(136, 28);
            projeLB.TabIndex = 6;
            projeLB.Text = "Proje Seçiniz : ";
            // 
            // isBitimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(projeLB);
            Controls.Add(comboBoxProjeler);
            Controls.Add(gonderBT);
            Controls.Add(projeSureciRB);
            Controls.Add(dateTimePicker1);
            Controls.Add(isBitimiLB2);
            Controls.Add(isBitimiLB1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "isBitimi";
            Text = "Tamamlanan İş Bildirimi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label isBitimiLB1;
        private Label isBitimiLB2;
        private DateTimePicker dateTimePicker1;
        private RichTextBox projeSureciRB;
        private Button gonderBT;
        private ComboBox comboBoxProjeler;
        private Label projeLB;
    }
}