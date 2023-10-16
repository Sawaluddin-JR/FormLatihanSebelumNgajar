namespace FormLatihanSebelumNgajar
{
    partial class Form4
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
            this.textAngka1 = new System.Windows.Forms.TextBox();
            this.textAngka2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.textHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textAngka1
            // 
            this.textAngka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAngka1.Location = new System.Drawing.Point(260, 131);
            this.textAngka1.Multiline = true;
            this.textAngka1.Name = "textAngka1";
            this.textAngka1.Size = new System.Drawing.Size(318, 41);
            this.textAngka1.TabIndex = 0;
            // 
            // textAngka2
            // 
            this.textAngka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAngka2.Location = new System.Drawing.Point(259, 201);
            this.textAngka2.Multiline = true;
            this.textAngka2.Name = "textAngka2";
            this.textAngka2.Size = new System.Drawing.Size(319, 41);
            this.textAngka2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Angka 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angka 2 :";
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.Salmon;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.Location = new System.Drawing.Point(260, 350);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 51);
            this.btntambah.TabIndex = 4;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.BackColor = System.Drawing.Color.Wheat;
            this.btnkurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkurang.Location = new System.Drawing.Point(341, 350);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(75, 51);
            this.btnkurang.TabIndex = 5;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = false;
            this.btnkurang.Click += new System.EventHandler(this.btnkurang_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbagi.Location = new System.Drawing.Point(422, 350);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(75, 51);
            this.btnbagi.TabIndex = 6;
            this.btnbagi.Text = ":";
            this.btnbagi.UseVisualStyleBackColor = false;
            this.btnbagi.Click += new System.EventHandler(this.btnbagi_Click);
            // 
            // btnkali
            // 
            this.btnkali.BackColor = System.Drawing.Color.SpringGreen;
            this.btnkali.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkali.Location = new System.Drawing.Point(503, 350);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(75, 51);
            this.btnkali.TabIndex = 7;
            this.btnkali.Text = "x";
            this.btnkali.UseVisualStyleBackColor = false;
            this.btnkali.Click += new System.EventHandler(this.btnkali_Click);
            // 
            // textHasil
            // 
            this.textHasil.Enabled = false;
            this.textHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHasil.Location = new System.Drawing.Point(259, 274);
            this.textHasil.Multiline = true;
            this.textHasil.Name = "textHasil";
            this.textHasil.Size = new System.Drawing.Size(319, 41);
            this.textHasil.TabIndex = 9;
            this.textHasil.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasil      :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kalukatore";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHasil);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAngka2);
            this.Controls.Add(this.textAngka1);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuis Pertemuan 10";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAngka1;
        private System.Windows.Forms.TextBox textAngka2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.TextBox textHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}