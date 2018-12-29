namespace MVCDemo
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointGraphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sasiadujacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaskadowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oknoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointViewToolStripMenuItem,
            this.pointGraphicsToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // pointViewToolStripMenuItem
            // 
            this.pointViewToolStripMenuItem.Name = "pointViewToolStripMenuItem";
            this.pointViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pointViewToolStripMenuItem.Text = "Point View";
            this.pointViewToolStripMenuItem.Click += new System.EventHandler(this.pointViewToolStripMenuItem_Click);
            // 
            // pointGraphicsToolStripMenuItem
            // 
            this.pointGraphicsToolStripMenuItem.Name = "pointGraphicsToolStripMenuItem";
            this.pointGraphicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pointGraphicsToolStripMenuItem.Text = "Point Graphics";
            this.pointGraphicsToolStripMenuItem.Click += new System.EventHandler(this.pointGraphicsToolStripMenuItem_Click);
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sasiadujacoToolStripMenuItem,
            this.kaskadowoToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.oknoToolStripMenuItem.Text = "Windows";
            // 
            // sasiadujacoToolStripMenuItem
            // 
            this.sasiadujacoToolStripMenuItem.Name = "sasiadujacoToolStripMenuItem";
            this.sasiadujacoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sasiadujacoToolStripMenuItem.Text = "Tile vertical";
            this.sasiadujacoToolStripMenuItem.Click += new System.EventHandler(this.sasiadujacoToolStripMenuItem_Click);
            // 
            // kaskadowoToolStripMenuItem
            // 
            this.kaskadowoToolStripMenuItem.Name = "kaskadowoToolStripMenuItem";
            this.kaskadowoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaskadowoToolStripMenuItem.Text = "Cascade";
            this.kaskadowoToolStripMenuItem.Click += new System.EventHandler(this.kaskadowoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MVC Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointGraphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sasiadujacoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaskadowoToolStripMenuItem;
    }
}

