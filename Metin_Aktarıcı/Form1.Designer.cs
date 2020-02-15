namespace Metin_Aktarıcı
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
            this.txtAktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYazi = new System.Windows.Forms.Label();
            this.btnAktar = new System.Windows.Forms.Button();
            this.txtAktar2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAktar
            // 
            this.txtAktar.Location = new System.Drawing.Point(62, 66);
            this.txtAktar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAktar.Name = "txtAktar";
            this.txtAktar.Size = new System.Drawing.Size(374, 35);
            this.txtAktar.TabIndex = 0;
            this.txtAktar.TextChanged += new System.EventHandler(this.txtAktar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metin Giriniz:";
            // 
            // lblYazi
            // 
            this.lblYazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblYazi.Location = new System.Drawing.Point(62, 141);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(374, 61);
            this.lblYazi.TabIndex = 2;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(532, 66);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(138, 73);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // txtAktar2
            // 
            this.txtAktar2.Location = new System.Drawing.Point(62, 247);
            this.txtAktar2.Name = "txtAktar2";
            this.txtAktar2.Size = new System.Drawing.Size(362, 35);
            this.txtAktar2.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(488, 245);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 33);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Aktif Mi?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(492, 195);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 33);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Sil";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 653);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtAktar2);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAktar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.TextBox txtAktar2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

