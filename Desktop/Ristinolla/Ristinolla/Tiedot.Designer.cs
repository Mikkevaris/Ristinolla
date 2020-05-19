namespace Ristinolla
{
    partial class Tiedot
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbEtunimi = new System.Windows.Forms.TextBox();
            this.TbSukunimi = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPeruuta = new System.Windows.Forms.Button();
            this.DtpSyntymä = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Syntymäaika";
            // 
            // TbEtunimi
            // 
            this.TbEtunimi.Location = new System.Drawing.Point(191, 78);
            this.TbEtunimi.Name = "TbEtunimi";
            this.TbEtunimi.Size = new System.Drawing.Size(269, 26);
            this.TbEtunimi.TabIndex = 3;
            this.TbEtunimi.Validating += new System.ComponentModel.CancelEventHandler(this.TbEtunimi_Validating);
            // 
            // TbSukunimi
            // 
            this.TbSukunimi.Location = new System.Drawing.Point(191, 124);
            this.TbSukunimi.Name = "TbSukunimi";
            this.TbSukunimi.Size = new System.Drawing.Size(269, 26);
            this.TbSukunimi.TabIndex = 4;
            this.TbSukunimi.Validating += new System.ComponentModel.CancelEventHandler(this.TbEtunimi_Validating);
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(381, 231);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(79, 41);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Syötä pelaajan tiedot:";
            // 
            // BtnPeruuta
            // 
            this.BtnPeruuta.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPeruuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeruuta.Location = new System.Drawing.Point(262, 231);
            this.BtnPeruuta.Name = "BtnPeruuta";
            this.BtnPeruuta.Size = new System.Drawing.Size(103, 41);
            this.BtnPeruuta.TabIndex = 8;
            this.BtnPeruuta.Text = "Peruuta";
            this.BtnPeruuta.UseVisualStyleBackColor = false;
            this.BtnPeruuta.Click += new System.EventHandler(this.BtnPeruuta_Click);
            // 
            // DtpSyntymä
            // 
            this.DtpSyntymä.Location = new System.Drawing.Point(191, 167);
            this.DtpSyntymä.Name = "DtpSyntymä";
            this.DtpSyntymä.Size = new System.Drawing.Size(269, 26);
            this.DtpSyntymä.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Tiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 284);
            this.Controls.Add(this.DtpSyntymä);
            this.Controls.Add(this.BtnPeruuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TbSukunimi);
            this.Controls.Add(this.TbEtunimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(510, 340);
            this.MinimumSize = new System.Drawing.Size(510, 340);
            this.Name = "Tiedot";
            this.Text = "Tiedot1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tiedot_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbEtunimi;
        private System.Windows.Forms.TextBox TbSukunimi;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPeruuta;
        private System.Windows.Forms.DateTimePicker DtpSyntymä;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}