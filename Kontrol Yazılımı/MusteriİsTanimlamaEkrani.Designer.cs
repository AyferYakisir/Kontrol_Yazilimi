namespace Kontrol_Yazılımı
{
    partial class MusteriİsTanimlamaEkrani
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
            isEklePB = new PictureBox();
            listBoxProjeler = new ListBox();
            silButton = new Button();
            projelerLB = new Label();
            ((System.ComponentModel.ISupportInitialize)isEklePB).BeginInit();
            SuspendLayout();
            // 
            // isEklePB
            // 
            isEklePB.Image = Properties.Resources.isEkleme;
            isEklePB.Location = new Point(718, 12);
            isEklePB.Name = "isEklePB";
            isEklePB.Size = new Size(70, 53);
            isEklePB.SizeMode = PictureBoxSizeMode.Zoom;
            isEklePB.TabIndex = 0;
            isEklePB.TabStop = false;
            isEklePB.Click += isEklePB_Click;
            // 
            // listBoxProjeler
            // 
            listBoxProjeler.BackColor = Color.Gainsboro;
            listBoxProjeler.ForeColor = SystemColors.Desktop;
            listBoxProjeler.FormattingEnabled = true;
            listBoxProjeler.HorizontalScrollbar = true;
            listBoxProjeler.IntegralHeight = false;
            listBoxProjeler.ItemHeight = 20;
            listBoxProjeler.Location = new Point(45, 73);
            listBoxProjeler.Name = "listBoxProjeler";
            listBoxProjeler.Size = new Size(585, 344);
            listBoxProjeler.TabIndex = 1;
            // 
            // silButton
            // 
            silButton.BackColor = Color.Gainsboro;
            silButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            silButton.ForeColor = Color.MediumSeaGreen;
            silButton.Location = new Point(661, 373);
            silButton.Name = "silButton";
            silButton.Size = new Size(70, 44);
            silButton.TabIndex = 2;
            silButton.Text = "SİL";
            silButton.UseVisualStyleBackColor = false;
            silButton.Click += silButton_Click;
            // 
            // projelerLB
            // 
            projelerLB.AutoSize = true;
            projelerLB.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            projelerLB.ForeColor = Color.MediumSeaGreen;
            projelerLB.Location = new Point(253, 30);
            projelerLB.Name = "projelerLB";
            projelerLB.Size = new Size(132, 35);
            projelerLB.TabIndex = 3;
            projelerLB.Text = "PROJELER";
            // 
            // MusteriİsTanimlamaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(projelerLB);
            Controls.Add(silButton);
            Controls.Add(listBoxProjeler);
            Controls.Add(isEklePB);
            Name = "MusteriİsTanimlamaEkrani";
            Text = "MusteriİsTanimlamEkrani";
            ((System.ComponentModel.ISupportInitialize)isEklePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox isEklePB;
        private ListBox listBoxProjeler;
        private Button silButton;
        private Label projelerLB;
    }
}