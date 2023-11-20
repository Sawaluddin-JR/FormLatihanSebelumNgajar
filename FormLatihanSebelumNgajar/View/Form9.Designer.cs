namespace FormLatihanSebelumNgajar.View
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_english = new System.Windows.Forms.PictureBox();
            this.pictureBox_indonesia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_english)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_indonesia)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dark Mode";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(134, 63);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(50, 25);
            this.guna2ToggleSwitch1.TabIndex = 2;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome To My Aplikasi";
            // 
            // pictureBox_english
            // 
            this.pictureBox_english.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox_english.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_english.Image")));
            this.pictureBox_english.Location = new System.Drawing.Point(732, 50);
            this.pictureBox_english.Name = "pictureBox_english";
            this.pictureBox_english.Size = new System.Drawing.Size(56, 37);
            this.pictureBox_english.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_english.TabIndex = 4;
            this.pictureBox_english.TabStop = false;
            this.pictureBox_english.Click += new System.EventHandler(this.pictureBox_english_Click);
            // 
            // pictureBox_indonesia
            // 
            this.pictureBox_indonesia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_indonesia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_indonesia.Image")));
            this.pictureBox_indonesia.Location = new System.Drawing.Point(732, 51);
            this.pictureBox_indonesia.Name = "pictureBox_indonesia";
            this.pictureBox_indonesia.Size = new System.Drawing.Size(56, 37);
            this.pictureBox_indonesia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_indonesia.TabIndex = 5;
            this.pictureBox_indonesia.TabStop = false;
            this.pictureBox_indonesia.Click += new System.EventHandler(this.pictureBox_indonesia_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_indonesia);
            this.Controls.Add(this.pictureBox_english);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_english)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_indonesia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_english;
        private System.Windows.Forms.PictureBox pictureBox_indonesia;
    }
}