namespace Kontrol_Yazılımı
{
    partial class IsArayanEkrani
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
         private System.Windows.Forms.ListBox listBoxIsler;
         private System.Windows.Forms.Button btnBasvur;
        private void InitializeComponent()
        {
            listBoxIsler = new ListBox();
            btnBasvur = new Button();
            SuspendLayout();
            // 
            // listBoxIsler
            // 
            listBoxIsler.FormattingEnabled = true;
            listBoxIsler.ItemHeight = 20;
            listBoxIsler.Location = new Point(87, 65);
            listBoxIsler.Name = "listBoxIsler";
            listBoxIsler.Size = new Size(532, 304);
            listBoxIsler.TabIndex = 0;
            // 
            // btnBasvur
            // 
            btnBasvur.Location = new Point(302, 417);
            btnBasvur.Name = "btnBasvur";
            btnBasvur.Size = new Size(100, 30);
            btnBasvur.TabIndex = 1;
            btnBasvur.Text = "Başvur";
            btnBasvur.UseVisualStyleBackColor = true;
            // 
            // IsArayanEkrani
            // 
            ClientSize = new Size(854, 478);
            Controls.Add(listBoxIsler);
            Controls.Add(btnBasvur);
            Name = "IsArayanEkrani";
            Text = "İş Arama Ekranı";
            ResumeLayout(false);
        }

        #endregion
    }
}