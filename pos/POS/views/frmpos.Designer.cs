namespace POS
{
    partial class frmpos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pnlOrderTrans = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlCustAmt = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblOrderTotAmt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcOrder = new DevExpress.XtraGrid.GridControl();
            this.gvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOrderTrans)).BeginInit();
            this.pnlOrderTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCustAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pnlOrderTrans);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(819, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(124, 513);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Function Keys";
            // 
            // pnlOrderTrans
            // 
            this.pnlOrderTrans.Controls.Add(this.panelControl2);
            this.pnlOrderTrans.Controls.Add(this.pnlCustAmt);
            this.pnlOrderTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderTrans.Location = new System.Drawing.Point(2, 22);
            this.pnlOrderTrans.Name = "pnlOrderTrans";
            this.pnlOrderTrans.Size = new System.Drawing.Size(120, 489);
            this.pnlOrderTrans.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.button2);
            this.panelControl2.Controls.Add(this.button1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 102);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(116, 385);
            this.panelControl2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 104);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlCustAmt
            // 
            this.pnlCustAmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustAmt.Location = new System.Drawing.Point(2, 2);
            this.pnlCustAmt.Name = "pnlCustAmt";
            this.pnlCustAmt.Size = new System.Drawing.Size(116, 100);
            this.pnlCustAmt.TabIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Gray;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.lblOrderId);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 491);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(819, 22);
            this.panelControl3.TabIndex = 7;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOrderId.Location = new System.Drawing.Point(83, 2);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(31, 13);
            this.lblOrderId.TabIndex = 4;
            this.lblOrderId.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Transaction ID:";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lblOrderTotAmt);
            this.panelControl4.Controls.Add(this.label5);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 389);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(819, 102);
            this.panelControl4.TabIndex = 9;
            // 
            // lblOrderTotAmt
            // 
            this.lblOrderTotAmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderTotAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotAmt.Location = new System.Drawing.Point(2, 2);
            this.lblOrderTotAmt.Name = "lblOrderTotAmt";
            this.lblOrderTotAmt.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblOrderTotAmt.Size = new System.Drawing.Size(815, 80);
            this.lblOrderTotAmt.TabIndex = 4;
            this.lblOrderTotAmt.Text = "123,456,789.00";
            this.lblOrderTotAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(2, 81);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.label5.Size = new System.Drawing.Size(815, 19);
            this.label5.TabIndex = 3;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcOrder);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 102);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(819, 287);
            this.panelControl1.TabIndex = 10;
            // 
            // gcOrder
            // 
            this.gcOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrder.Location = new System.Drawing.Point(2, 2);
            this.gcOrder.MainView = this.gvOrder;
            this.gcOrder.Name = "gcOrder";
            this.gcOrder.Size = new System.Drawing.Size(815, 283);
            this.gcOrder.TabIndex = 0;
            this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrder});
            this.gcOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcOrder_KeyDown);
            // 
            // gvOrder
            // 
            this.gvOrder.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvOrder.Appearance.Row.Options.UseFont = true;
            this.gvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gvOrder.GridControl = this.gcOrder;
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.OptionsView.ShowGroupPanel = false;
            this.gvOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvOrder_KeyDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.textBox1);
            this.panelControl5.Controls.Add(this.label2);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(819, 102);
            this.panelControl5.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(815, 83);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1234567890";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 90);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.label2.Size = new System.Drawing.Size(815, 10);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(943, 513);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POINT OF SALES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmpos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmpos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlOrderTrans)).EndInit();
            this.pnlOrderTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCustAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl pnlOrderTrans;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pnlCustAmt;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public System.Windows.Forms.Label lblOrderTotAmt;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraGrid.GridControl gcOrder;
        public DevExpress.XtraGrid.Views.Grid.GridView gvOrder;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        public System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblOrderId;
    }
}

