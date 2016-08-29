namespace POS.views
{
    partial class frmItems
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcItems = new DevExpress.XtraGrid.GridControl();
            this.gvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.qsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcItems);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(815, 379);
            this.panelControl1.TabIndex = 0;
            // 
            // gcItems
            // 
            this.gcItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItems.Location = new System.Drawing.Point(2, 2);
            this.gcItems.MainView = this.gvItems;
            this.gcItems.Name = "gcItems";
            this.gcItems.Size = new System.Drawing.Size(811, 375);
            this.gcItems.TabIndex = 0;
            this.gcItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItems});
            // 
            // gvItems
            // 
            this.gvItems.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvItems.Appearance.Row.Options.UseFont = true;
            this.gvItems.GridControl = this.gcItems;
            this.gvItems.Name = "gvItems";
            this.gvItems.OptionsView.ShowGroupPanel = false;
            this.gvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvItems_KeyDown);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.qsearch);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(815, 58);
            this.panelControl2.TabIndex = 1;
            // 
            // qsearch
            // 
            this.qsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.qsearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.qsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qsearch.Location = new System.Drawing.Point(2, 18);
            this.qsearch.Name = "qsearch";
            this.qsearch.Size = new System.Drawing.Size(811, 38);
            this.qsearch.TabIndex = 0;
            this.qsearch.Text = "12121";
            this.qsearch.TextChanged += new System.EventHandler(this.qsearch_TextChanged);
            this.qsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qsearch_KeyDown);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 437);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.KeyPreview = true;
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Query";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraGrid.GridControl gcItems;
        public DevExpress.XtraGrid.Views.Grid.GridView gvItems;
        public System.Windows.Forms.TextBox qsearch;
    }
}