using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using POS.controller.Items;
using POS.controller.Order;
namespace POS.views
{
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        ItemCtrl itemCtrl;
        OrderCtrl orderCtrl;
        public frmItems()
        {
            InitializeComponent();
            itemCtrl = new ItemCtrl(this);

        }
        public frmItems(frmpos _frmpos)
        {
            InitializeComponent();
            itemCtrl = new ItemCtrl(this);
            orderCtrl = new OrderCtrl(_frmpos);

        }
        private void qsearch_KeyDown(object sender, KeyEventArgs e)
      {
            TextBox txtitem = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                itemCtrl.orderInsert();
            }
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            
        }

        private void qsearch_TextChanged(object sender, EventArgs e)
        {
            TextBox seach = sender as TextBox;
            itemCtrl.itemGet(seach.Text);
        }

        private void gvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemCtrl.orderInsert();
                var i = itemCtrl.isSuccess;
                orderCtrl.load();
            }
        }
    }
}
