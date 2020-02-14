namespace opterecenje_nastavnika
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
            this.btnSati = new System.Windows.Forms.Button();
            this.btnPredmet = new System.Windows.Forms.Button();
            this.btnNastavnik = new System.Windows.Forms.Button();
            this.txtSati = new System.Windows.Forms.TextBox();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.txtNastavnik = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstPredmeti = new System.Windows.Forms.ListBox();
            this.lstNastavnici = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSati
            // 
            this.btnSati.Location = new System.Drawing.Point(374, 128);
            this.btnSati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSati.Name = "btnSati";
            this.btnSati.Size = new System.Drawing.Size(127, 19);
            this.btnSati.TabIndex = 25;
            this.btnSati.Text = "Spremi";
            this.btnSati.UseVisualStyleBackColor = true;
            this.btnSati.Click += new System.EventHandler(this.btnSati_Click);
            // 
            // btnPredmet
            // 
            this.btnPredmet.Location = new System.Drawing.Point(192, 229);
            this.btnPredmet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPredmet.Name = "btnPredmet";
            this.btnPredmet.Size = new System.Drawing.Size(130, 24);
            this.btnPredmet.TabIndex = 24;
            this.btnPredmet.Text = "Dodaj";
            this.btnPredmet.UseVisualStyleBackColor = true;
            this.btnPredmet.Click += new System.EventHandler(this.btnPredmet_Click);
            // 
            // btnNastavnik
            // 
            this.btnNastavnik.Location = new System.Drawing.Point(31, 229);
            this.btnNastavnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNastavnik.Name = "btnNastavnik";
            this.btnNastavnik.Size = new System.Drawing.Size(128, 24);
            this.btnNastavnik.TabIndex = 23;
            this.btnNastavnik.Text = "Dodaj";
            this.btnNastavnik.UseVisualStyleBackColor = true;
            this.btnNastavnik.Click += new System.EventHandler(this.btnNastavnik_Click);
            // 
            // txtSati
            // 
            this.txtSati.Location = new System.Drawing.Point(374, 97);
            this.txtSati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSati.Name = "txtSati";
            this.txtSati.Size = new System.Drawing.Size(128, 20);
            this.txtSati.TabIndex = 22;
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(192, 197);
            this.txtPredmet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(131, 20);
            this.txtPredmet.TabIndex = 21;
            // 
            // txtNastavnik
            // 
            this.txtNastavnik.Location = new System.Drawing.Point(31, 197);
            this.txtNastavnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNastavnik.Name = "txtNastavnik";
            this.txtNastavnik.Size = new System.Drawing.Size(128, 20);
            this.txtNastavnik.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(291, 122);
            this.dataGridView1.TabIndex = 19;
            // 
            // lstPredmeti
            // 
            this.lstPredmeti.FormattingEnabled = true;
            this.lstPredmeti.Location = new System.Drawing.Point(192, 43);
            this.lstPredmeti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPredmeti.Name = "lstPredmeti";
            this.lstPredmeti.Size = new System.Drawing.Size(131, 134);
            this.lstPredmeti.TabIndex = 18;
            this.lstPredmeti.SelectedIndexChanged += new System.EventHandler(this.lstPredmeti_SelectedIndexChanged);
            // 
            // lstNastavnici
            // 
            this.lstNastavnici.FormattingEnabled = true;
            this.lstNastavnici.Location = new System.Drawing.Point(31, 43);
            this.lstNastavnici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstNastavnici.Name = "lstNastavnici";
            this.lstNastavnici.Size = new System.Drawing.Size(128, 134);
            this.lstNastavnici.TabIndex = 17;
            this.lstNastavnici.SelectedIndexChanged += new System.EventHandler(this.lstNastavnici_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Opterećenje nastavnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Broj sati za predmet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Predmet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nastavnik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 448);
            this.Controls.Add(this.btnSati);
            this.Controls.Add(this.btnPredmet);
            this.Controls.Add(this.btnNastavnik);
            this.Controls.Add(this.txtSati);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.txtNastavnik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstPredmeti);
            this.Controls.Add(this.lstNastavnici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Evidencija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSati;
        private System.Windows.Forms.Button btnPredmet;
        private System.Windows.Forms.Button btnNastavnik;
        private System.Windows.Forms.TextBox txtSati;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.TextBox txtNastavnik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstPredmeti;
        private System.Windows.Forms.ListBox lstNastavnici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

