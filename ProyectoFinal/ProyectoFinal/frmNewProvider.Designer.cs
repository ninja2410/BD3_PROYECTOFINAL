namespace ProyectoFinal
{
    partial class frmNewProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewProvider));
            this.txtNameProvider = new System.Windows.Forms.TextBox();
            this.txtPhoneProvider = new System.Windows.Forms.TextBox();
            this.txtNitProvider = new System.Windows.Forms.TextBox();
            this.txtContactProvider = new System.Windows.Forms.TextBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProvider = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkProvider = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkProvider.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameProvider
            // 
            this.txtNameProvider.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProvider.ForeColor = System.Drawing.Color.Gray;
            this.txtNameProvider.Location = new System.Drawing.Point(19, 98);
            this.txtNameProvider.Name = "txtNameProvider";
            this.txtNameProvider.Size = new System.Drawing.Size(303, 34);
            this.txtNameProvider.TabIndex = 0;
            this.txtNameProvider.Text = "Escriba el nombre del proveedor";
            this.toolTip1.SetToolTip(this.txtNameProvider, "Nombre del Proveedor");
            this.txtNameProvider.Enter += new System.EventHandler(this.txtNameProvider_Enter);
            this.txtNameProvider.Leave += new System.EventHandler(this.txtNameProvider_Leave);
            this.txtNameProvider.MouseHover += new System.EventHandler(this.txtNameProvider_MouseHover);
            // 
            // txtPhoneProvider
            // 
            this.txtPhoneProvider.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneProvider.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneProvider.Location = new System.Drawing.Point(19, 147);
            this.txtPhoneProvider.Name = "txtPhoneProvider";
            this.txtPhoneProvider.Size = new System.Drawing.Size(203, 34);
            this.txtPhoneProvider.TabIndex = 1;
            this.txtPhoneProvider.Text = "Telefono del Proveedor";
            this.txtPhoneProvider.Enter += new System.EventHandler(this.txtPhoneProvider_Enter);
            this.txtPhoneProvider.Leave += new System.EventHandler(this.txtPhoneProvider_Leave);
            // 
            // txtNitProvider
            // 
            this.txtNitProvider.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNitProvider.ForeColor = System.Drawing.Color.Gray;
            this.txtNitProvider.Location = new System.Drawing.Point(328, 98);
            this.txtNitProvider.Name = "txtNitProvider";
            this.txtNitProvider.Size = new System.Drawing.Size(182, 34);
            this.txtNitProvider.TabIndex = 2;
            this.txtNitProvider.Text = "NIT del Proveedor";
            this.txtNitProvider.Enter += new System.EventHandler(this.txtNitProvider_Enter);
            this.txtNitProvider.Leave += new System.EventHandler(this.txtNitProvider_Leave);
            // 
            // txtContactProvider
            // 
            this.txtContactProvider.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactProvider.ForeColor = System.Drawing.Color.Gray;
            this.txtContactProvider.Location = new System.Drawing.Point(236, 147);
            this.txtContactProvider.Name = "txtContactProvider";
            this.txtContactProvider.Size = new System.Drawing.Size(274, 34);
            this.txtContactProvider.TabIndex = 3;
            this.txtContactProvider.Text = "E-mail del Proveedor";
            this.txtContactProvider.Enter += new System.EventHandler(this.txtContactProvider_Enter);
            this.txtContactProvider.Leave += new System.EventHandler(this.txtContactProvider_Leave);
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.BackColor = System.Drawing.Color.Gray;
            this.lblshow.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.ForeColor = System.Drawing.Color.White;
            this.lblshow.Location = new System.Drawing.Point(35, 14);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(332, 45);
            this.lblshow.TabIndex = 4;
            this.lblshow.Text = "NUEVO PROVEEDOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblshow);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 77);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(364, 237);
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 51);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProvider.Appearance.Options.UseFont = true;
            this.btnAddProvider.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnAddProvider.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProvider.Image")));
            this.btnAddProvider.Location = new System.Drawing.Point(19, 237);
            this.btnAddProvider.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(146, 51);
            this.btnAddProvider.TabIndex = 8;
            this.btnAddProvider.Text = "Agregar";
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(-5, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 77);
            this.panel2.TabIndex = 6;
            // 
            // chkProvider
            // 
            this.chkProvider.EditValue = true;
            this.chkProvider.Location = new System.Drawing.Point(419, 187);
            this.chkProvider.Name = "chkProvider";
            this.chkProvider.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProvider.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.chkProvider.Properties.Appearance.Options.UseFont = true;
            this.chkProvider.Properties.Appearance.Options.UseForeColor = true;
            this.chkProvider.Properties.Caption = "Habilitar";
            this.chkProvider.Size = new System.Drawing.Size(91, 30);
            this.chkProvider.TabIndex = 9;
            // 
            // frmNewProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(522, 300);
            this.Controls.Add(this.chkProvider);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtContactProvider);
            this.Controls.Add(this.txtNitProvider);
            this.Controls.Add(this.txtPhoneProvider);
            this.Controls.Add(this.txtNameProvider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmNewProvider";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNewProvider";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkProvider.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameProvider;
        private System.Windows.Forms.TextBox txtPhoneProvider;
        private System.Windows.Forms.TextBox txtNitProvider;
        private System.Windows.Forms.TextBox txtContactProvider;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAddProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.CheckEdit chkProvider;
    }
}