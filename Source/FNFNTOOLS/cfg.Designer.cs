namespace FNFNTOOLS
{
    partial class cfg
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoolean = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateBackup = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.chReadOnly = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShowGrass = new System.Windows.Forms.ComboBox();
            this.cbShowFPS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMouse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVsync = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDistanceQuality = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbFoliageQuality = new System.Windows.Forms.ComboBox();
            this.cbShadowQuality = new System.Windows.Forms.ComboBox();
            this.cbEffectsQuality = new System.Windows.Forms.ComboBox();
            this.cbTextureQuality = new System.Windows.Forms.ComboBox();
            this.cbAntiAliasing = new System.Windows.Forms.ComboBox();
            this.cbPostProcess = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.ForeColor = System.Drawing.Color.Silver;
            this.txtPath.Location = new System.Drawing.Point(0, 575);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(545, 13);
            this.txtPath.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "FortGameUserSettings";
            // 
            // cbBoolean
            // 
            this.cbBoolean.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoolean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoolean.FormattingEnabled = true;
            this.cbBoolean.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cbBoolean.Location = new System.Drawing.Point(77, 104);
            this.cbBoolean.Name = "cbBoolean";
            this.cbBoolean.Size = new System.Drawing.Size(121, 21);
            this.cbBoolean.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Motion Blur";
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCreateBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCreateBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBackup.Font = new System.Drawing.Font("Exo 2", 8.25F);
            this.btnCreateBackup.Location = new System.Drawing.Point(555, 102);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(94, 23);
            this.btnCreateBackup.TabIndex = 19;
            this.btnCreateBackup.Text = "Backup";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // btnApply
            // 
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Exo 2", 8.25F);
            this.btnApply.Location = new System.Drawing.Point(669, 236);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 23);
            this.btnApply.TabIndex = 20;
            this.btnApply.Text = "Apply Settings";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRestoreBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBackup.Font = new System.Drawing.Font("Exo 2", 8.25F);
            this.btnRestoreBackup.Location = new System.Drawing.Point(669, 102);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Size = new System.Drawing.Size(94, 23);
            this.btnRestoreBackup.TabIndex = 21;
            this.btnRestoreBackup.Text = "Restore Backup";
            this.btnRestoreBackup.UseVisualStyleBackColor = true;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // chReadOnly
            // 
            this.chReadOnly.AutoSize = true;
            this.chReadOnly.ForeColor = System.Drawing.Color.White;
            this.chReadOnly.Location = new System.Drawing.Point(537, 242);
            this.chReadOnly.Name = "chReadOnly";
            this.chReadOnly.Size = new System.Drawing.Size(112, 17);
            this.chReadOnly.TabIndex = 22;
            this.chReadOnly.Text = "Enable Read Only";
            this.chReadOnly.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Show Grass";
            // 
            // cbShowGrass
            // 
            this.cbShowGrass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowGrass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowGrass.FormattingEnabled = true;
            this.cbShowGrass.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cbShowGrass.Location = new System.Drawing.Point(77, 157);
            this.cbShowGrass.Name = "cbShowGrass";
            this.cbShowGrass.Size = new System.Drawing.Size(121, 21);
            this.cbShowGrass.TabIndex = 24;
            // 
            // cbShowFPS
            // 
            this.cbShowFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowFPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowFPS.FormattingEnabled = true;
            this.cbShowFPS.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cbShowFPS.Location = new System.Drawing.Point(77, 210);
            this.cbShowFPS.Name = "cbShowFPS";
            this.cbShowFPS.Size = new System.Drawing.Size(121, 21);
            this.cbShowFPS.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Show FPS";
            // 
            // cbMouse
            // 
            this.cbMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMouse.FormattingEnabled = true;
            this.cbMouse.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cbMouse.Location = new System.Drawing.Point(274, 158);
            this.cbMouse.Name = "cbMouse";
            this.cbMouse.Size = new System.Drawing.Size(121, 21);
            this.cbMouse.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Disable Mouse Acceleration";
            // 
            // cbVsync
            // 
            this.cbVsync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVsync.FormattingEnabled = true;
            this.cbVsync.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cbVsync.Location = new System.Drawing.Point(274, 104);
            this.cbVsync.Name = "cbVsync";
            this.cbVsync.Size = new System.Drawing.Size(121, 21);
            this.cbVsync.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Use VSync";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Exo 2 Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Scalability Groups";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 14);
            this.label8.TabIndex = 40;
            this.label8.Text = "Post Process Quality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 14);
            this.label9.TabIndex = 38;
            this.label9.Text = "Texture Quality";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 14);
            this.label10.TabIndex = 36;
            this.label10.Text = "Shadown Quality";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(81, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 14);
            this.label11.TabIndex = 34;
            this.label11.Text = "Anti Aliasing Quality";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 14);
            this.label12.TabIndex = 33;
            this.label12.Text = "View Distance Quality";
            // 
            // cbDistanceQuality
            // 
            this.cbDistanceQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistanceQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDistanceQuality.FormattingEnabled = true;
            this.cbDistanceQuality.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbDistanceQuality.Location = new System.Drawing.Point(77, 326);
            this.cbDistanceQuality.Name = "cbDistanceQuality";
            this.cbDistanceQuality.Size = new System.Drawing.Size(121, 21);
            this.cbDistanceQuality.TabIndex = 32;
            this.cbDistanceQuality.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(291, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 14);
            this.label13.TabIndex = 42;
            this.label13.Text = "Effects Quality";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Exo 2 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(195, 478);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 14);
            this.label14.TabIndex = 44;
            this.label14.Text = "Foliage Quality";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Exo 2", 9.7F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(432, 345);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(97, 84);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "Low = 0\nMedium = 1\nHigh = 2\nEpic = 3\n";
            // 
            // cbFoliageQuality
            // 
            this.cbFoliageQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoliageQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFoliageQuality.FormattingEnabled = true;
            this.cbFoliageQuality.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbFoliageQuality.Location = new System.Drawing.Point(178, 495);
            this.cbFoliageQuality.Name = "cbFoliageQuality";
            this.cbFoliageQuality.Size = new System.Drawing.Size(121, 21);
            this.cbFoliageQuality.TabIndex = 45;
            // 
            // cbShadowQuality
            // 
            this.cbShadowQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShadowQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShadowQuality.FormattingEnabled = true;
            this.cbShadowQuality.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbShadowQuality.Location = new System.Drawing.Point(77, 432);
            this.cbShadowQuality.Name = "cbShadowQuality";
            this.cbShadowQuality.Size = new System.Drawing.Size(121, 21);
            this.cbShadowQuality.TabIndex = 37;
            // 
            // cbEffectsQuality
            // 
            this.cbEffectsQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEffectsQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEffectsQuality.FormattingEnabled = true;
            this.cbEffectsQuality.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbEffectsQuality.Location = new System.Drawing.Point(274, 432);
            this.cbEffectsQuality.Name = "cbEffectsQuality";
            this.cbEffectsQuality.Size = new System.Drawing.Size(121, 21);
            this.cbEffectsQuality.TabIndex = 43;
            // 
            // cbTextureQuality
            // 
            this.cbTextureQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextureQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTextureQuality.FormattingEnabled = true;
            this.cbTextureQuality.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbTextureQuality.Location = new System.Drawing.Point(274, 380);
            this.cbTextureQuality.Name = "cbTextureQuality";
            this.cbTextureQuality.Size = new System.Drawing.Size(121, 21);
            this.cbTextureQuality.TabIndex = 39;
            // 
            // cbAntiAliasing
            // 
            this.cbAntiAliasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAntiAliasing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAntiAliasing.FormattingEnabled = true;
            this.cbAntiAliasing.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbAntiAliasing.Location = new System.Drawing.Point(77, 379);
            this.cbAntiAliasing.Name = "cbAntiAliasing";
            this.cbAntiAliasing.Size = new System.Drawing.Size(121, 21);
            this.cbAntiAliasing.TabIndex = 35;
            // 
            // cbPostProcess
            // 
            this.cbPostProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPostProcess.FormattingEnabled = true;
            this.cbPostProcess.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbPostProcess.Location = new System.Drawing.Point(274, 326);
            this.cbPostProcess.Name = "cbPostProcess";
            this.cbPostProcess.Size = new System.Drawing.Size(121, 21);
            this.cbPostProcess.TabIndex = 41;
            // 
            // cfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(831, 586);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cbFoliageQuality);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbEffectsQuality);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbPostProcess);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTextureQuality);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbShadowQuality);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbAntiAliasing);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbDistanceQuality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbVsync);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbShowFPS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbShowGrass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chReadOnly);
            this.Controls.Add(this.btnRestoreBackup);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCreateBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBoolean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "cfg";
            this.Text = "cfg";
            this.Load += new System.EventHandler(this.cfg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoolean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateBackup;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRestoreBackup;
        private System.Windows.Forms.CheckBox chReadOnly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbShowGrass;
        private System.Windows.Forms.ComboBox cbShowFPS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVsync;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbDistanceQuality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbFoliageQuality;
        private System.Windows.Forms.ComboBox cbShadowQuality;
        private System.Windows.Forms.ComboBox cbEffectsQuality;
        private System.Windows.Forms.ComboBox cbTextureQuality;
        private System.Windows.Forms.ComboBox cbAntiAliasing;
        private System.Windows.Forms.ComboBox cbPostProcess;
    }
}