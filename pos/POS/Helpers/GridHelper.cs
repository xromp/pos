using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
namespace POS.Helpers
{
    class GridHelper
    {
        
        public static void setData(GridControl _gc,DataTable _dt)
        {
            GridControl _gridControl = _gc;
            GridView _gridView = (GridView)_gridControl.MainView;

            _gridControl.BeginUpdate();
            try
            {
                _gridView.Columns.Clear();
                
                _gridControl.DataSource = null;
                _gridControl.DataSource = _dt;
                _gridControl.Refresh();
            }
            finally
            {
                _gridControl.EndUpdate();
            }
        
        }
    }
}
