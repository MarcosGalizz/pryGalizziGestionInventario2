namespace pryGalizziGestiónInventario
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.tabFuncionalidades = new System.Windows.Forms.TabControl();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.cboNombres = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.tbpReporteInventario = new System.Windows.Forms.TabPage();
            this.tabFuncionalidades.SuspendLayout();
            this.tbpProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFuncionalidades
            // 
            this.tabFuncionalidades.Controls.Add(this.tbpProductos);
            this.tabFuncionalidades.Controls.Add(this.tbpBuscar);
            this.tabFuncionalidades.Controls.Add(this.tbpReporteInventario);
            this.tabFuncionalidades.Location = new System.Drawing.Point(31, 30);
            this.tabFuncionalidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFuncionalidades.Name = "tabFuncionalidades";
            this.tabFuncionalidades.SelectedIndex = 0;
            this.tabFuncionalidades.Size = new System.Drawing.Size(843, 475);
            this.tabFuncionalidades.TabIndex = 0;
            // 
            // tbpProductos
            // 
            this.tbpProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(196)))), ((int)(((byte)(180)))));
            this.tbpProductos.Controls.Add(this.cboCategorias);
            this.tbpProductos.Controls.Add(this.cboNombres);
            this.tbpProductos.Controls.Add(this.btnEliminar);
            this.tbpProductos.Controls.Add(this.btnModificar);
            this.tbpProductos.Controls.Add(this.btnAgregar);
            this.tbpProductos.Controls.Add(this.lblCategorias);
            this.tbpProductos.Controls.Add(this.txtStock);
            this.tbpProductos.Controls.Add(this.lblStock);
            this.tbpProductos.Controls.Add(this.txtPrecio);
            this.tbpProductos.Controls.Add(this.lblPrecio);
            this.tbpProductos.Controls.Add(this.txtDescripcion);
            this.tbpProductos.Controls.Add(this.lblDescripcion);
            this.tbpProductos.Controls.Add(this.lblNombre);
            this.tbpProductos.Controls.Add(this.txtCodigo);
            this.tbpProductos.Controls.Add(this.lblCodigo);
            this.tbpProductos.Controls.Add(this.btnBuscar);
            this.tbpProductos.Location = new System.Drawing.Point(4, 25);
            this.tbpProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpProductos.Name = "tbpProductos";
            this.tbpProductos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpProductos.Size = new System.Drawing.Size(835, 446);
            this.tbpProductos.TabIndex = 0;
            this.tbpProductos.Text = "Productos";
            // 
            // cboCategorias
            // 
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(147, 353);
            this.cboCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(276, 24);
            this.cboCategorias.TabIndex = 17;
            // 
            // cboNombres
            // 
            this.cboNombres.FormattingEnabled = true;
            this.cboNombres.Location = new System.Drawing.Point(147, 86);
            this.cboNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNombres.Name = "cboNombres";
            this.cboNombres.Size = new System.Drawing.Size(276, 24);
            this.cboNombres.TabIndex = 16;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(581, 290);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(179, 73);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(581, 161);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(179, 73);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(581, 41);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(179, 73);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(55, 357);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(73, 16);
            this.lblCategorias.TabIndex = 11;
            this.lblCategorias.Text = "Categorías";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(147, 290);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(132, 22);
            this.txtStock.TabIndex = 10;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(55, 294);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(147, 241);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(55, 245);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 138);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(276, 78);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(55, 138);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 92);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(147, 41);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(55, 44);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(324, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(11)))), ((int)(((byte)(64)))));
            this.tbpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpBuscar.Location = new System.Drawing.Point(4, 25);
            this.tbpBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpBuscar.Size = new System.Drawing.Size(835, 446);
            this.tbpBuscar.TabIndex = 1;
            this.tbpBuscar.Text = "Buscar";
            // 
            // tbpReporteInventario
            // 
            this.tbpReporteInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(74)))));
            this.tbpReporteInventario.Location = new System.Drawing.Point(4, 25);
            this.tbpReporteInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpReporteInventario.Name = "tbpReporteInventario";
            this.tbpReporteInventario.Size = new System.Drawing.Size(835, 446);
            this.tbpReporteInventario.TabIndex = 2;
            this.tbpReporteInventario.Text = "Reporte de inventario";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 554);
            this.Controls.Add(this.tabFuncionalidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInicio";
            this.Text = "Gestión de inventario";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tabFuncionalidades.ResumeLayout(false);
            this.tbpProductos.ResumeLayout(false);
            this.tbpProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFuncionalidades;
        private System.Windows.Forms.TabPage tbpProductos;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tbpReporteInventario;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboNombres;
        private System.Windows.Forms.ComboBox cboCategorias;
    }
}