namespace Iran_ITA3_sifra
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.desifrovat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rot = new System.Windows.Forms.TextBox();
            this.vstup = new System.Windows.Forms.TextBox();
            this.sifra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desifrovat
            // 
            this.desifrovat.Location = new System.Drawing.Point(140, 39);
            this.desifrovat.Name = "desifrovat";
            this.desifrovat.Size = new System.Drawing.Size(75, 22);
            this.desifrovat.TabIndex = 13;
            this.desifrovat.Text = "Dešifrovat";
            this.desifrovat.UseVisualStyleBackColor = true;
            this.desifrovat.Click += new System.EventHandler(this.desifrovat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "písmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rotace o";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Šifra:";
            // 
            // rot
            // 
            this.rot.Location = new System.Drawing.Point(69, 41);
            this.rot.Name = "rot";
            this.rot.Size = new System.Drawing.Size(17, 20);
            this.rot.TabIndex = 9;
            // 
            // vstup
            // 
            this.vstup.Location = new System.Drawing.Point(49, 12);
            this.vstup.Name = "vstup";
            this.vstup.Size = new System.Drawing.Size(85, 20);
            this.vstup.TabIndex = 8;
            // 
            // sifra
            // 
            this.sifra.Location = new System.Drawing.Point(140, 11);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(75, 22);
            this.sifra.TabIndex = 7;
            this.sifra.Text = "Šifrovat";
            this.sifra.UseVisualStyleBackColor = true;
            this.sifra.Click += new System.EventHandler(this.sifra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 73);
            this.Controls.Add(this.desifrovat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rot);
            this.Controls.Add(this.vstup);
            this.Controls.Add(this.sifra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button desifrovat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rot;
        private System.Windows.Forms.TextBox vstup;
        private System.Windows.Forms.Button sifra;
    }
}

