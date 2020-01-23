namespace CheckBox
{
    partial class Form1
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
            this.Dorucak = new System.Windows.Forms.CheckBox();
            this.Rucak = new System.Windows.Forms.CheckBox();
            this.Vecera = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SakrijiNarudzbu = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dorucak
            // 
            this.Dorucak.AutoSize = true;
            this.Dorucak.Location = new System.Drawing.Point(76, 84);
            this.Dorucak.Name = "Dorucak";
            this.Dorucak.Size = new System.Drawing.Size(67, 17);
            this.Dorucak.TabIndex = 1;
            this.Dorucak.Text = "Doručak";
            this.Dorucak.UseVisualStyleBackColor = true;
            this.Dorucak.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Rucak
            // 
            this.Rucak.AutoSize = true;
            this.Rucak.Location = new System.Drawing.Point(78, 134);
            this.Rucak.Name = "Rucak";
            this.Rucak.Size = new System.Drawing.Size(58, 17);
            this.Rucak.TabIndex = 2;
            this.Rucak.Text = "Ručak";
            this.Rucak.UseVisualStyleBackColor = true;
            // 
            // Vecera
            // 
            this.Vecera.AutoSize = true;
            this.Vecera.Location = new System.Drawing.Point(76, 181);
            this.Vecera.Name = "Vecera";
            this.Vecera.Size = new System.Drawing.Size(60, 17);
            this.Vecera.TabIndex = 3;
            this.Vecera.Text = "Večera";
            this.Vecera.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pošalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SakrijiNarudzbu
            // 
            this.SakrijiNarudzbu.AutoSize = true;
            this.SakrijiNarudzbu.Location = new System.Drawing.Point(204, 245);
            this.SakrijiNarudzbu.Name = "SakrijiNarudzbu";
            this.SakrijiNarudzbu.Size = new System.Drawing.Size(101, 17);
            this.SakrijiNarudzbu.TabIndex = 7;
            this.SakrijiNarudzbu.Text = "Sakriji narudžbu";
            this.SakrijiNarudzbu.UseVisualStyleBackColor = true;
            this.SakrijiNarudzbu.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 117);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 349);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SakrijiNarudzbu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vecera);
            this.Controls.Add(this.Rucak);
            this.Controls.Add(this.Dorucak);
            this.Name = "Form1";
            this.Text = "Upotreba CheckBox kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Dorucak;
        private System.Windows.Forms.CheckBox Rucak;
        private System.Windows.Forms.CheckBox Vecera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SakrijiNarudzbu;
        private System.Windows.Forms.TextBox textBox1;
    }
}

