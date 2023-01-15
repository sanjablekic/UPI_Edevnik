namespace Ednevnik
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUcitajUcenike = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblIspis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(32, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 180);
            this.listBox1.TabIndex = 0;
            // 
            // btnUcitajUcenike
            // 
            this.btnUcitajUcenike.Location = new System.Drawing.Point(32, 94);
            this.btnUcitajUcenike.Name = "btnUcitajUcenike";
            this.btnUcitajUcenike.Size = new System.Drawing.Size(200, 52);
            this.btnUcitajUcenike.TabIndex = 1;
            this.btnUcitajUcenike.Text = "Učitaj učenike";
            this.btnUcitajUcenike.UseVisualStyleBackColor = true;
            this.btnUcitajUcenike.Click += new System.EventHandler(this.btnUcitajUcenike_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5A",
            "6A",
            "7A",
            "8A"});
            this.comboBox1.Location = new System.Drawing.Point(32, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odabir razreda:";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(32, 375);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(200, 52);
            this.btnOdaberi.TabIndex = 4;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(381, 451);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(237, 52);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ocjena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bilješka:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(381, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 22);
            this.textBox2.TabIndex = 9;
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(378, 46);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(0, 17);
            this.lblIspis.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Izostanak:";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(655, 14);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(122, 27);
            this.btnOdjava.TabIndex = 17;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(381, 415);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Nije prisutan/na";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 515);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUcitajUcenike);
            this.Controls.Add(this.listBox1);
            this.Name = "Form3";
            this.Text = "Ednevnik - profesor";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUcitajUcenike;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}