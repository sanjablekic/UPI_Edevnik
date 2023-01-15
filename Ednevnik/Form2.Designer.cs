namespace Ednevnik
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblIspis = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ocjena i izostanaka:";
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(36, 74);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(0, 17);
            this.lblIspis.TabIndex = 1;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(666, 20);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(122, 27);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Ednevnik - učenik";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.Button btnOdjava;
    }
}