namespace ProyectoFinal
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveChanges = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteClient = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlCliente = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNewClient,
            this.btnSaveChanges,
            this.btnDeleteClient});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(688, 141);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Caption = "Nuevo";
            this.btnNewClient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNewClient.Glyph")));
            this.btnNewClient.Id = 1;
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem1.Text = "Nuevo Cliente";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Ingresa un nuevo cliente al registro";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnNewClient.SuperTip = superToolTip1;
            this.btnNewClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewClient_ItemClick);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Caption = "Guardar Cambios";
            this.btnSaveChanges.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.Glyph")));
            this.btnSaveChanges.Id = 2;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem2.Text = "Guardar Cambios";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Guarda los cambios en el cliente seleccionado.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnSaveChanges.SuperTip = superToolTip2;
            this.btnSaveChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveChanges_ItemClick);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Caption = "Eliminar";
            this.btnDeleteClient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Glyph")));
            this.btnDeleteClient.Id = 3;
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem3.Text = "Eliminar";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Elimina el cliente seleccionado";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnDeleteClient.SuperTip = superToolTip3;
            this.btnDeleteClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteClient_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Administrar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewClient);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaveChanges);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteClient);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Opciones";
            // 
            // gridControlCliente
            // 
            this.gridControlCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCliente.Location = new System.Drawing.Point(0, 141);
            this.gridControlCliente.MainView = this.gridView1;
            this.gridControlCliente.MenuManager = this.ribbonControl1;
            this.gridControlCliente.Name = "gridControlCliente";
            this.gridControlCliente.Size = new System.Drawing.Size(688, 264);
            this.gridControlCliente.TabIndex = 1;
            this.gridControlCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlCliente;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 405);
            this.Controls.Add(this.gridControlCliente);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControlCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnNewClient;
        private DevExpress.XtraBars.BarButtonItem btnSaveChanges;
        private DevExpress.XtraBars.BarButtonItem btnDeleteClient;
    }
}