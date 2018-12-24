using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MVCDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Model.Instance.Initialize( Consts.POINTS, Consts.MAXH );
        }

        private void pointViewToolStripMenuItem_Click( object sender, EventArgs e )
        {
            PointView pv = new PointView();
            pv.MdiParent = this;
            pv.Show();
        }

        private void pointGraphicsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            PointGraphics pv = new PointGraphics();
            pv.MdiParent = this;
            pv.Show();
        }

        private void sasiadujacoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.LayoutMdi( MdiLayout.TileVertical );
        }

        private void kaskadowoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.LayoutMdi( MdiLayout.Cascade );
        }
    }
}