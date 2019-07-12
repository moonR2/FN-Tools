namespace FNFNTOOLS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SideMenu = new System.Windows.Forms.Panel();
            this.btnCfg = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnResolution = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.btnFov = new System.Windows.Forms.Button();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SideMenu.Controls.Add(this.btnFov);
            this.SideMenu.Controls.Add(this.btnCfg);
            this.SideMenu.Controls.Add(this.btnSupport);
            this.SideMenu.Controls.Add(this.btnResolution);
            this.SideMenu.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.SideMenu, "SideMenu");
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.SideMenu_Paint);
            // 
            // btnCfg
            // 
            this.btnCfg.FlatAppearance.BorderSize = 0;
            this.btnCfg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCfg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.btnCfg, "btnCfg");
            this.btnCfg.ForeColor = System.Drawing.Color.White;
            this.btnCfg.Name = "btnCfg";
            this.btnCfg.UseVisualStyleBackColor = true;
            this.btnCfg.Click += new System.EventHandler(this.btnCfg_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSupport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.btnSupport, "btnSupport");
            this.btnSupport.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResolution
            // 
            this.btnResolution.FlatAppearance.BorderSize = 0;
            this.btnResolution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnResolution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.btnResolution, "btnResolution");
            this.btnResolution.ForeColor = System.Drawing.Color.White;
            this.btnResolution.Name = "btnResolution";
            this.btnResolution.UseVisualStyleBackColor = true;
            this.btnResolution.Click += new System.EventHandler(this.btnResolution_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FNFNTOOLS.Properties.Resources.Logo_text;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ParentPanel
            // 
            resources.ApplyResources(this.ParentPanel, "ParentPanel");
            this.ParentPanel.Name = "ParentPanel";
            // 
            // btnFov
            // 
            this.btnFov.FlatAppearance.BorderSize = 0;
            this.btnFov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.btnFov, "btnFov");
            this.btnFov.ForeColor = System.Drawing.Color.White;
            this.btnFov.Name = "btnFov";
            this.btnFov.UseVisualStyleBackColor = true;
            this.btnFov.Click += new System.EventHandler(this.BtnFov_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Button btnResolution;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnCfg;
        private System.Windows.Forms.Button btnFov;
    }
}

