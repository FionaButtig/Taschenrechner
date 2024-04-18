namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB = new System.Windows.Forms.Button();
            this.vorzeichenB = new System.Windows.Forms.Button();
            this.divB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.siebenB = new System.Windows.Forms.Button();
            this.achtB = new System.Windows.Forms.Button();
            this.neunB = new System.Windows.Forms.Button();
            this.multiB = new System.Windows.Forms.Button();
            this.vierB = new System.Windows.Forms.Button();
            this.fünfB = new System.Windows.Forms.Button();
            this.sechsB = new System.Windows.Forms.Button();
            this.minusB = new System.Windows.Forms.Button();
            this.EinsB = new System.Windows.Forms.Button();
            this.ZweiB = new System.Windows.Forms.Button();
            this.dreiB = new System.Windows.Forms.Button();
            this.nullB = new System.Windows.Forms.Button();
            this.decimalB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.ergebnisB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB
            // 
            this.CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB.Font = new System.Drawing.Font("Gadugi", 12F);
            this.CB.Location = new System.Drawing.Point(34, 148);
            this.CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(156, 64);
            this.CB.TabIndex = 4;
            this.CB.Text = "C";
            this.CB.UseVisualStyleBackColor = false;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // vorzeichenB
            // 
            this.vorzeichenB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vorzeichenB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vorzeichenB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vorzeichenB.Location = new System.Drawing.Point(210, 148);
            this.vorzeichenB.Name = "vorzeichenB";
            this.vorzeichenB.Size = new System.Drawing.Size(68, 64);
            this.vorzeichenB.TabIndex = 24;
            this.vorzeichenB.Text = "±";
            this.vorzeichenB.UseVisualStyleBackColor = false;
            this.vorzeichenB.Click += new System.EventHandler(this.vorzeichenB_Click);
            // 
            // divB
            // 
            this.divB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.divB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.divB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divB.Location = new System.Drawing.Point(297, 148);
            this.divB.Name = "divB";
            this.divB.Size = new System.Drawing.Size(68, 64);
            this.divB.TabIndex = 25;
            this.divB.Text = "/";
            this.divB.UseVisualStyleBackColor = false;
            this.divB.Click += new System.EventHandler(this.divB_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 20F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(34, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 71);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Gadugi", 16F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(34, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 57);
            this.textBox2.TabIndex = 27;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // siebenB
            // 
            this.siebenB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siebenB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siebenB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siebenB.Location = new System.Drawing.Point(34, 236);
            this.siebenB.Name = "siebenB";
            this.siebenB.Size = new System.Drawing.Size(68, 64);
            this.siebenB.TabIndex = 28;
            this.siebenB.Text = "7";
            this.siebenB.UseVisualStyleBackColor = false;
            this.siebenB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // achtB
            // 
            this.achtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.achtB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.achtB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.achtB.Location = new System.Drawing.Point(122, 236);
            this.achtB.Name = "achtB";
            this.achtB.Size = new System.Drawing.Size(68, 64);
            this.achtB.TabIndex = 29;
            this.achtB.Text = "8";
            this.achtB.UseVisualStyleBackColor = false;
            this.achtB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // neunB
            // 
            this.neunB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.neunB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.neunB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neunB.Location = new System.Drawing.Point(210, 236);
            this.neunB.Name = "neunB";
            this.neunB.Size = new System.Drawing.Size(68, 64);
            this.neunB.TabIndex = 30;
            this.neunB.Text = "9";
            this.neunB.UseVisualStyleBackColor = false;
            this.neunB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // multiB
            // 
            this.multiB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiB.Location = new System.Drawing.Point(297, 236);
            this.multiB.Name = "multiB";
            this.multiB.Size = new System.Drawing.Size(68, 64);
            this.multiB.TabIndex = 31;
            this.multiB.Text = "*";
            this.multiB.UseVisualStyleBackColor = false;
            this.multiB.Click += new System.EventHandler(this.multiB_Click);
            // 
            // vierB
            // 
            this.vierB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vierB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vierB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vierB.Location = new System.Drawing.Point(34, 324);
            this.vierB.Name = "vierB";
            this.vierB.Size = new System.Drawing.Size(68, 64);
            this.vierB.TabIndex = 32;
            this.vierB.Text = "4";
            this.vierB.UseVisualStyleBackColor = false;
            this.vierB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // fünfB
            // 
            this.fünfB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fünfB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fünfB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fünfB.Location = new System.Drawing.Point(122, 324);
            this.fünfB.Name = "fünfB";
            this.fünfB.Size = new System.Drawing.Size(68, 64);
            this.fünfB.TabIndex = 33;
            this.fünfB.Text = "5";
            this.fünfB.UseVisualStyleBackColor = false;
            this.fünfB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // sechsB
            // 
            this.sechsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sechsB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sechsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sechsB.Location = new System.Drawing.Point(210, 324);
            this.sechsB.Name = "sechsB";
            this.sechsB.Size = new System.Drawing.Size(68, 64);
            this.sechsB.TabIndex = 34;
            this.sechsB.Text = "6";
            this.sechsB.UseVisualStyleBackColor = false;
            this.sechsB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // minusB
            // 
            this.minusB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minusB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minusB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusB.Location = new System.Drawing.Point(297, 324);
            this.minusB.Name = "minusB";
            this.minusB.Size = new System.Drawing.Size(68, 64);
            this.minusB.TabIndex = 35;
            this.minusB.Text = "-";
            this.minusB.UseVisualStyleBackColor = false;
            this.minusB.Click += new System.EventHandler(this.minusB_Click);
            // 
            // EinsB
            // 
            this.EinsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EinsB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EinsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EinsB.Location = new System.Drawing.Point(34, 412);
            this.EinsB.Name = "EinsB";
            this.EinsB.Size = new System.Drawing.Size(68, 64);
            this.EinsB.TabIndex = 36;
            this.EinsB.Text = "1";
            this.EinsB.UseVisualStyleBackColor = false;
            this.EinsB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // ZweiB
            // 
            this.ZweiB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZweiB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZweiB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZweiB.Location = new System.Drawing.Point(122, 412);
            this.ZweiB.Name = "ZweiB";
            this.ZweiB.Size = new System.Drawing.Size(68, 64);
            this.ZweiB.TabIndex = 37;
            this.ZweiB.Text = "2";
            this.ZweiB.UseVisualStyleBackColor = false;
            this.ZweiB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // dreiB
            // 
            this.dreiB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dreiB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dreiB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dreiB.Location = new System.Drawing.Point(210, 412);
            this.dreiB.Name = "dreiB";
            this.dreiB.Size = new System.Drawing.Size(68, 64);
            this.dreiB.TabIndex = 38;
            this.dreiB.Text = "3";
            this.dreiB.UseVisualStyleBackColor = false;
            this.dreiB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // nullB
            // 
            this.nullB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nullB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nullB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nullB.Location = new System.Drawing.Point(34, 498);
            this.nullB.Name = "nullB";
            this.nullB.Size = new System.Drawing.Size(68, 73);
            this.nullB.TabIndex = 39;
            this.nullB.Text = "0";
            this.nullB.UseVisualStyleBackColor = false;
            this.nullB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // decimalB
            // 
            this.decimalB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.decimalB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.decimalB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalB.Location = new System.Drawing.Point(122, 498);
            this.decimalB.Name = "decimalB";
            this.decimalB.Size = new System.Drawing.Size(68, 73);
            this.decimalB.TabIndex = 40;
            this.decimalB.Text = ",";
            this.decimalB.UseVisualStyleBackColor = false;
            this.decimalB.Click += new System.EventHandler(this.zahlenEingabe);
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addB.Location = new System.Drawing.Point(297, 412);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(68, 64);
            this.addB.TabIndex = 41;
            this.addB.Text = "+";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // ergebnisB
            // 
            this.ergebnisB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ergebnisB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ergebnisB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ergebnisB.Location = new System.Drawing.Point(210, 498);
            this.ergebnisB.Name = "ergebnisB";
            this.ergebnisB.Size = new System.Drawing.Size(155, 73);
            this.ergebnisB.TabIndex = 42;
            this.ergebnisB.Text = "=";
            this.ergebnisB.UseVisualStyleBackColor = false;
            this.ergebnisB.Click += new System.EventHandler(this.ergebnisB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(396, 594);
            this.Controls.Add(this.ergebnisB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.decimalB);
            this.Controls.Add(this.nullB);
            this.Controls.Add(this.dreiB);
            this.Controls.Add(this.ZweiB);
            this.Controls.Add(this.EinsB);
            this.Controls.Add(this.minusB);
            this.Controls.Add(this.sechsB);
            this.Controls.Add(this.fünfB);
            this.Controls.Add(this.vierB);
            this.Controls.Add(this.multiB);
            this.Controls.Add(this.neunB);
            this.Controls.Add(this.achtB);
            this.Controls.Add(this.siebenB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.divB);
            this.Controls.Add(this.vorzeichenB);
            this.Controls.Add(this.CB);
            this.Font = new System.Drawing.Font("Gadugi", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CB;
        private System.Windows.Forms.Button vorzeichenB;
        private System.Windows.Forms.Button divB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button siebenB;
        private System.Windows.Forms.Button achtB;
        private System.Windows.Forms.Button neunB;
        private System.Windows.Forms.Button multiB;
        private System.Windows.Forms.Button vierB;
        private System.Windows.Forms.Button fünfB;
        private System.Windows.Forms.Button sechsB;
        private System.Windows.Forms.Button minusB;
        private System.Windows.Forms.Button EinsB;
        private System.Windows.Forms.Button ZweiB;
        private System.Windows.Forms.Button dreiB;
        private System.Windows.Forms.Button nullB;
        private System.Windows.Forms.Button decimalB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button ergebnisB;
    }
}

