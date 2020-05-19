namespace Ristinolla
{
    partial class Ladatutpelaajat
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnPeruuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(243, 326);
            this.checkedListBox1.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(163, 344);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(92, 44);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnPeruuta
            // 
            this.BtnPeruuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeruuta.Location = new System.Drawing.Point(43, 344);
            this.BtnPeruuta.Name = "BtnPeruuta";
            this.BtnPeruuta.Size = new System.Drawing.Size(114, 44);
            this.BtnPeruuta.TabIndex = 2;
            this.BtnPeruuta.Text = "Peruuta";
            this.BtnPeruuta.UseVisualStyleBackColor = true;
            this.BtnPeruuta.Click += new System.EventHandler(this.BtnPeruuta_Click);
            // 
            // Ladatutpelaajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 400);
            this.Controls.Add(this.BtnPeruuta);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Ladatutpelaajat";
            this.Text = "Ladatutpelaajat";
            this.Load += new System.EventHandler(this.Ladatutpelaajat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnPeruuta;
    }
}