using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MVCDemo
{
    public partial class PointView : Form, IView
    {
        public PointView()
        {
            InitializeComponent();

            pointBindingSource.DataSource = Model.Instance.Points;
        }

        private void dataGridView1_CellValueChanged( object sender, DataGridViewCellEventArgs e )
        {
            Controller.Instance.RaiseModelChange( this, new ModelChangeEventArgs( e.RowIndex ) );
        }

        #region IView Members

        public void ModelChange( object sender, ModelChangeEventArgs e )
        {
            if ( e.PointIndex >= 0 && e.PointIndex < Consts.POINTS )
            {
                DataGridViewCell cell = dataGridView1.Rows[e.PointIndex].Cells[1];

                cell.Value = Model.Instance.Points[e.PointIndex].Y;
                dataGridView1.InvalidateCell( cell );
            }
        }

        #endregion

        private void PointView_Load( object sender, EventArgs e )
        {
            Controller.Instance.RegisterView( this );
        }

        private void PointView_FormClosed( object sender, FormClosedEventArgs e )
        {
            Controller.Instance.UnregisterView( this );
        }
    }
}