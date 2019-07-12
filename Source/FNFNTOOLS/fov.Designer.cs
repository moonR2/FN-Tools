namespace FNFNTOOLS
{
    partial class fov
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
            this.cbFov = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnAppFov = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.chRO = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFov
            // 
            this.cbFov.FormattingEnabled = true;
            this.cbFov.Items.AddRange(new object[] {
            "90",
            "100",
            "110",
            "120"});
            this.cbFov.Location = new System.Drawing.Point(187, 102);
            this.cbFov.Name = "cbFov";
            this.cbFov.Size = new System.Drawing.Size(121, 21);
            this.cbFov.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FNFNTOOLS.Properties.Resources.infoGrid;
            this.pictureBox1.Location = new System.Drawing.Point(27, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 170);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.Silver;
            this.txtInfo.Location = new System.Drawing.Point(42, 343);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(478, 146);
            this.txtInfo.TabIndex = 15;
            this.txtInfo.Text = "Fov changer only works after using FovSwapper look at github for it and use it at" +
    " your own risk because looks sospicius. This program only changes your .ini sett" +
    "ings which is 100% allowed. \n";
            // 
            // btnAppFov
            // 
            this.btnAppFov.Location = new System.Drawing.Point(620, 102);
            this.btnAppFov.Name = "btnAppFov";
            this.btnAppFov.Size = new System.Drawing.Size(110, 23);
            this.btnAppFov.TabIndex = 17;
            this.btnAppFov.Text = "Apply Fov";
            this.btnAppFov.UseVisualStyleBackColor = true;
            this.btnAppFov.Click += new System.EventHandler(this.BtnAppFov_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtPath.ForeColor = System.Drawing.Color.Silver;
            this.txtPath.Location = new System.Drawing.Point(-3, 570);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(601, 20);
            this.txtPath.TabIndex = 18;
            // 
            // chRO
            // 
            this.chRO.AutoSize = true;
            this.chRO.ForeColor = System.Drawing.Color.Silver;
            this.chRO.Location = new System.Drawing.Point(424, 54);
            this.chRO.Name = "chRO";
            this.chRO.Size = new System.Drawing.Size(112, 17);
            this.chRO.TabIndex = 19;
            this.chRO.Text = "Enable Read Only";
            this.chRO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(424, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Resolution for Nvidia Panel";
            // 
            // txtRec
            // 
            this.txtRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtRec.ForeColor = System.Drawing.Color.Silver;
            this.txtRec.Location = new System.Drawing.Point(419, 122);
            this.txtRec.Name = "txtRec";
            this.txtRec.ReadOnly = true;
            this.txtRec.Size = new System.Drawing.Size(144, 20);
            this.txtRec.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(542, 343);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(282, 146);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "Instructions\n1. Select FOV \n2. Enable Read Only\n3. Apply Fov\n4. Create a custom r" +
    "esolution with the recommended resolution\n\n";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(620, 64);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(110, 23);
            this.btnOpenFolder.TabIndex = 23;
            this.btnOpenFolder.Text = "Open Config Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.BtnOpenFolder_Click);
            // 
            // fov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(831, 586);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chRO);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnAppFov);
            this.Controls.Add(this.cbFov);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fov";
            this.Text = "fov";
            this.Load += new System.EventHandler(this.Fov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Button btnAppFov;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox chRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}