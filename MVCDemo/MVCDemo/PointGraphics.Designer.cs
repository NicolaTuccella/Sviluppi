namespace MVCDemo
{
    partial class PointGraphics
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
            this.SuspendLayout();
            // 
            // PointGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 430, 265 );
            this.Name = "PointGraphics";
            this.Text = "PointGraphics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.PointGraphics_FormClosed );
            this.Paint += new System.Windows.Forms.PaintEventHandler( this.PointGraphics_Paint );
            this.MouseUp += new System.Windows.Forms.MouseEventHandler( this.PointGraphics_MouseUp );
            this.MouseMove += new System.Windows.Forms.MouseEventHandler( this.PointGraphics_MouseMove );
            this.ResizeEnd += new System.EventHandler( this.PointGraphics_ResizeEnd );
            this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.PointGraphics_MouseDown );
            this.Load += new System.EventHandler( this.PointGraphics_Load );
            this.ResumeLayout( false );

        }

        #endregion
    }
}