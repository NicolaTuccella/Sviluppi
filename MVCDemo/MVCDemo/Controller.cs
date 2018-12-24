using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDemo
{
    public class Controller
    {
        #region Singleton
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if ( instance == null ) instance = new Controller();

                return instance;
            }
        }
        #endregion

        public delegate void ModelChangeDelegate( object sender, ModelChangeEventArgs e );
        public event ModelChangeDelegate ModelChangeEvent;

        public void RegisterView( IView view )
        {
            this.ModelChangeEvent += new ModelChangeDelegate( view.ModelChange );
        }
        public void UnregisterView( IView view )
        {
            this.ModelChangeEvent -= new ModelChangeDelegate( view.ModelChange );
        }

        public void RaiseModelChange( object sender, ModelChangeEventArgs e )
        {
            if ( ModelChangeEvent != null )
                ModelChangeEvent( sender, e );
        }
    }

    public interface IView
    {
        void ModelChange( object sender, ModelChangeEventArgs e );
    }

    public class ModelChangeEventArgs
    {
        public int PointIndex;

        private ModelChangeEventArgs() {}
        public ModelChangeEventArgs( int PointIndex )
        {
            this.PointIndex = PointIndex;
        }
    }
}
