namespace Ednevnik
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUcenik = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnRazrednik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka :";
            // 
            // btnUcenik
            // 
            this.btnUcenik.Location = new System.Drawing.Point(132, 190);
            this.btnUcenik.Name = "btnUcenik";
            this.btnUcenik.Size = new System.Drawing.Size(207, 61);
            this.btnUcenik.TabIndex = 3;
            this.btnUcenik.Text = "UČENIK";
            this.btnUcenik.UseVisualStyleBackColor = true;
            this.btnUcenik.Click += new System.EventHandler(this.btnUcenik_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 5;
            // 
            // btnProfesor
            // 
            this.btnProfesor.Location = new System.Drawing.Point(132, 257);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(207, 61);
            this.btnProfesor.TabIndex = 6;
            this.btnProfesor.Text = "PROFESOR";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnRazrednik
            // 
            this.btnRazrednik.Location = new System.Drawing.Point(132, 324);
            this.btnRazrednik.Name = "btnRazrednik";
            this.btnRazrednik.Size = new System.Drawing.Size(207, 61);
            this.btnRazrednik.TabIndex = 7;
            this.btnRazrednik.Text = "RAZREDNIK";
            this.btnRazrednik.UseVisualStyleBackColor = true;
            this.btnRazrednik.Click += new System.EventHandler(this.btnRazrednik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prijavite se:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRazrednik);
            this.Controls.Add(this.btnProfesor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUcenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Ednevnik - prijava";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUcenik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnRazrednik;
        private System.Windows.Forms.Label label1;
    }
}

