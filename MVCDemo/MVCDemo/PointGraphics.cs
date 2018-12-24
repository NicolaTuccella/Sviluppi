using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MVCDemo
{
    public partial class PointGraphics : Form, IView
    {
        public PointGraphics()
        {
            InitializeComponent();

            this.SetStyle( ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true );
        }

        private void PointGraphics_Paint( object sender, PaintEventArgs e )
        {
            double xstep = (double)this.ClientRectangle.Width / Model.Instance.Points.Length;
            double ystep = (double)this.ClientRectangle.Height / Consts.MAXH;

            for ( int p = 0; p < Model.Instance.Points.Length - 1; p++ )
            {
                using ( Pen pn = new Pen( Color.Red, 2 ) )
                    e.Graphics.DrawRectangle( pn, new Rectangle( (int)( p * xstep ), (int)( Model.Instance.Points[p].Y * ystep ), 3, 3 ) );
                using ( Pen pn = new Pen( Color.Blue, 1 ) )
                    e.Graphics.DrawLine( pn,
                        new PointF( (int)( p * xstep ), (int)( Model.Instance.Points[p].Y * ystep ) ),
                        new PointF( (int)( ( p + 1 ) * xstep ), (int)( Model.Instance.Points[p + 1].Y * ystep ) ) );
            }
        }

        private void PointGraphics_ResizeEnd( object sender, EventArgs e )
        {
            this.Refresh();
        }

        #region IView Members

        public void ModelChange( object sender, ModelChangeEventArgs e )
        {
            Refresh();
        }

        #endregion

        private void PointGraphics_Load( object sender, EventArgs e )
        {
            Controller.Instance.RegisterView( this );
        }

        private void PointGraphics_FormClosed( object sender, FormClosedEventArgs e )
        {
            Controller.Instance.UnregisterView( this );
        }

        Point MovedPoint = null;
        int LastY;
        private void PointGraphics_MouseDown( object sender, MouseEventArgs e )
        {
            int pointX = e.X * Consts.POINTS / ClientRectangle.Width;
            if ( pointX >= 0 && pointX < Consts.POINTS )
            {
                MovedPoint = Model.Instance.Points[pointX];
                LastY = e.Y;
            }
        }
        private void PointGraphics_MouseMove( object sender, MouseEventArgs e )
        {
            if ( MovedPoint != null )
            {
                MovedPoint.Y += (int)( ( e.Y - LastY ) / ( (double)ClientRectangle.Height / Consts.MAXH ) );
                LastY = e.Y;

                Controller.Instance.RaiseModelChange( this, new ModelChangeEventArgs( MovedPoint.X ) );
            }
        }
        private void PointGraphics_MouseUp( object sender, MouseEventArgs e )
        {
            MovedPoint = null;
        }
    }
}