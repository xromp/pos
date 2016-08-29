using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using POS.controller.Order;
using POS.controller.Items;
using POS.views;
namespace POS
{
    public partial class frmpos : DevExpress.XtraEditors.XtraForm
    {
        OrderCtrl order;
        public frmpos()

        {
            InitializeComponent();
            order = new OrderCtrl(this);
            order.load();
        }
        private void frmpos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmpos_Load(object sender, EventArgs e)
        {
            //OrderCtrl orderApp = new OrderCtrl(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.itemGet();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gcOrder_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void gvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                order.itemGet();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            order.newOrder();
        }
    }
}
