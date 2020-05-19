namespace Ristinolla
{
    partial class Vastustaja
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
            this.BtnLataa = new System.Windows.Forms.Button();
            this.BtnUusi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTietokone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLataa
            // 
            this.BtnLataa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLataa.Location = new System.Drawing.Point(12, 151);
            this.BtnLataa.Name = "BtnLataa";
            this.BtnLataa.Size = new System.Drawing.Size(261, 49);
            this.BtnLataa.TabIndex = 3;
            this.BtnLataa.Text = "Lataa pelaaja";
            this.BtnLataa.UseVisualStyleBackColor = true;
            this.BtnLataa.Click += new System.EventHandler(this.BtnLataa_Click);
            // 
            // BtnUusi
            // 
            this.BtnUusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUusi.Location = new System.Drawing.Point(12, 80);
            this.BtnUusi.Name = "BtnUusi";
            this.BtnUusi.Size = new System.Drawing.Size(261, 49);
            this.BtnUusi.TabIndex = 2;
            this.BtnUusi.Text = "Uusi pelaaja";
            this.BtnUusi.UseVisualStyleBackColor = true;
            this.BtnUusi.Click += new System.EventHandler(this.BtnUusi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valitse vastustaja:";
            // 
            // BtnTietokone
            // 
            this.BtnTietokone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTietokone.Location = new System.Drawing.Point(12, 222);
            this.BtnTietokone.Name = "BtnTietokone";
            this.BtnTietokone.Size = new System.Drawing.Size(261, 49);
            this.BtnTietokone.TabIndex = 5;
            this.BtnTietokone.Text = "Tietokone";
            this.BtnTietokone.UseVisualStyleBackColor = true;
            this.BtnTietokone.Click += new System.EventHandler(this.BtnTietokone_Click);
            // 
            // Vastustaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 284);
            this.Controls.Add(this.BtnTietokone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLataa);
            this.Controls.Add(this.BtnUusi);
            this.MaximumSize = new System.Drawing.Size(315, 340);
            this.MinimumSize = new System.Drawing.Size(315, 340);
            this.Name = "Vastustaja";
            this.Text = "Vastustaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLataa;
        private System.Windows.Forms.Button BtnUusi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTietokone;
    }
}