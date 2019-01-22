namespace FNFNTOOLS
{
    partial class Resolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resolution));
            this.cbResX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbResY = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserRes = new System.Windows.Forms.TextBox();
            this.btnChangeRes = new System.Windows.Forms.Button();
            this.chReadOnly = new System.Windows.Forms.CheckBox();
            this.cbFps = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb3DRes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.chFullScreen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbResX
            // 
            this.cbResX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbResX.FormattingEnabled = true;
            this.cbResX.Items.AddRange(new object[] {
            "1511",
            "1444",
            "1279",
            "1153",
            "1079"});
            this.cbResX.Location = new System.Drawing.Point(176, 80);
            this.cbResX.Name = "cbResX";
            this.cbResX.Size = new System.Drawing.Size(107, 21);
            this.cbResX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ResolutionSizeX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbResY
            // 
            this.cbResY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbResY.FormattingEnabled = true;
            this.cbResY.Items.AddRange(new object[] {
            "1080"});
            this.cbResY.Location = new System.Drawing.Point(316, 80);
            this.cbResY.Name = "cbResY";
            this.cbResY.Size = new System.Drawing.Size(107, 21);
            this.cbResY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ResolutionSizeY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserRes
            // 
            this.txtUserRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtUserRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserRes.ForeColor = System.Drawing.Color.Silver;
            this.txtUserRes.Location = new System.Drawing.Point(549, 578);
            this.txtUserRes.Name = "txtUserRes";
            this.txtUserRes.ReadOnly = true;
            this.txtUserRes.Size = new System.Drawing.Size(286, 13);
            this.txtUserRes.TabIndex = 5;
            this.txtUserRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChangeRes
            // 
            this.btnChangeRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnChangeRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnChangeRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRes.Font = new System.Drawing.Font("Exo 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRes.ForeColor = System.Drawing.Color.White;
            this.btnChangeRes.Location = new System.Drawing.Point(577, 116);
            this.btnChangeRes.Name = "btnChangeRes";
            this.btnChangeRes.Size = new System.Drawing.Size(109, 23);
            this.btnChangeRes.TabIndex = 6;
            this.btnChangeRes.Text = "Apply Settings";
            this.btnChangeRes.UseVisualStyleBackColor = true;
            this.btnChangeRes.Click += new System.EventHandler(this.btnChangeRes_Click);
            // 
            // chReadOnly
            // 
            this.chReadOnly.AutoSize = true;
            this.chReadOnly.ForeColor = System.Drawing.Color.White;
            this.chReadOnly.Location = new System.Drawing.Point(450, 103);
            this.chReadOnly.Name = "chReadOnly";
            this.chReadOnly.Size = new System.Drawing.Size(112, 17);
            this.chReadOnly.TabIndex = 7;
            this.chReadOnly.Text = "Enable Read Only";
            this.chReadOnly.UseVisualStyleBackColor = true;
            // 
            // cbFps
            // 
            this.cbFps.FormattingEnabled = true;
            this.cbFps.Items.AddRange(new object[] {
            "60\t",
            "120",
            "240",
            "Unlimited"});
            this.cbFps.Location = new System.Drawing.Point(176, 136);
            this.cbFps.Name = "cbFps";
            this.cbFps.Size = new System.Drawing.Size(64, 21);
            this.cbFps.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(173, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "FPS Cap";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb3DRes
            // 
            this.cb3DRes.FormattingEnabled = true;
            this.cb3DRes.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60"});
            this.cb3DRes.Location = new System.Drawing.Point(316, 136);
            this.cb3DRes.Name = "cb3DRes";
            this.cb3DRes.Size = new System.Drawing.Size(65, 21);
            this.cb3DRes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(315, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "3D Res";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.Silver;
            this.txtInfo.Location = new System.Drawing.Point(186, 321);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(478, 142);
            this.txtInfo.TabIndex = 12;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FNFNTOOLS.Properties.Resources.infoGrid;
            this.pictureBox1.Location = new System.Drawing.Point(168, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 166);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.ForeColor = System.Drawing.Color.Silver;
            this.txtPath.Location = new System.Drawing.Point(4, 578);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(545, 13);
            this.txtPath.TabIndex = 14;
            // 
            // chFullScreen
            // 
            this.chFullScreen.AutoSize = true;
            this.chFullScreen.ForeColor = System.Drawing.Color.White;
            this.chFullScreen.Location = new System.Drawing.Point(450, 138);
            this.chFullScreen.Name = "chFullScreen";
            this.chFullScreen.Size = new System.Drawing.Size(106, 17);
            this.chFullScreen.TabIndex = 15;
            this.chFullScreen.Text = "Force FullScreen";
            this.chFullScreen.UseVisualStyleBackColor = true;
            // 
            // Resolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(831, 586);
            this.Controls.Add(this.chFullScreen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb3DRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFps);
            this.Controls.Add(this.chReadOnly);
            this.Controls.Add(this.btnChangeRes);
            this.Controls.Add(this.txtUserRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbResY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbResX);
            this.Name = "Resolution";
            this.Text = "Resolution";
            this.Load += new System.EventHandler(this.Resolution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbResX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbResY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserRes;
        private System.Windows.Forms.Button btnChangeRes;
        private System.Windows.Forms.CheckBox chReadOnly;
        private System.Windows.Forms.ComboBox cbFps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb3DRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox chFullScreen;
    }
}