﻿namespace ProyectoFinal
{
    partial class frmnewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnewClient));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtNit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(362, 138);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos del nuevo Cliente";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtTelefono);
            this.layoutControl1.Controls.Add(this.txtApellido);
            this.layoutControl1.Controls.Add(this.txtNombre);
            this.layoutControl1.Controls.Add(this.txtNit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(358, 116);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(181, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 38);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 38);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(230, 36);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtTelefono.StyleController = this.layoutControl1;
            this.txtTelefono.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(61, 36);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.StyleController = this.layoutControl1;
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(230, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.StyleController = this.layoutControl1;
            this.txtNombre.TabIndex = 5;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(61, 12);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(116, 20);
            this.txtNit.StyleController = this.layoutControl1;
            this.txtNit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutnit,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(358, 116);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutnit
            // 
            this.layoutnit.Control = this.txtNit;
            this.layoutnit.Location = new System.Drawing.Point(0, 0);
            this.layoutnit.Name = "layoutnit";
            this.layoutnit.Size = new System.Drawing.Size(169, 24);
            this.layoutnit.Text = "NIT:";
            this.layoutnit.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNombre;
            this.layoutControlItem2.Location = new System.Drawing.Point(169, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(169, 24);
            this.layoutControlItem2.Text = "Nombre:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtApellido;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(169, 24);
            this.layoutControlItem1.Text = "Apellido:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTelefono;
            this.layoutControlItem3.Location = new System.Drawing.Point(169, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(169, 24);
            this.layoutControlItem3.Text = "Telefono:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(169, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(169, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(169, 48);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmnewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 138);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "frmnewClient";
            this.Text = "Nuevo Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtApellido;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtNit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutnit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}