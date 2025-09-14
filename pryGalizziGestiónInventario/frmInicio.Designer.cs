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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.tabFuncionalidades = new System.Windows.Forms.TabControl();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.panBtnsTabProductos = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
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
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matCboCategorias = new MaterialSkin.Controls.MaterialComboBox();
            this.matTxtCategorias = new MaterialSkin.Controls.MaterialTextBox();
            this.matLblBuscar = new MaterialSkin.Controls.MaterialLabel();
            this.matBtnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.tbpReporteInventario = new System.Windows.Forms.TabPage();
            this.matBtnReporte = new MaterialSkin.Controls.MaterialButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.matBtnDestVentas = new MaterialSkin.Controls.MaterialButton();
            this.tabFuncionalidades.SuspendLayout();
            this.tbpProductos.SuspendLayout();
            this.panBtnsTabProductos.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.tbpReporteInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFuncionalidades
            // 
            this.tabFuncionalidades.Controls.Add(this.tbpProductos);
            this.tabFuncionalidades.Controls.Add(this.tbpBuscar);
            this.tabFuncionalidades.Controls.Add(this.tbpReporteInventario);
            this.tabFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFuncionalidades.Location = new System.Drawing.Point(34, 24);
            this.tabFuncionalidades.Margin = new System.Windows.Forms.Padding(5);
            this.tabFuncionalidades.Name = "tabFuncionalidades";
            this.tabFuncionalidades.SelectedIndex = 0;
            this.tabFuncionalidades.Size = new System.Drawing.Size(907, 556);
            this.tabFuncionalidades.TabIndex = 0;
            // 
            // tbpProductos
            // 
            this.tbpProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.tbpProductos.Controls.Add(this.panBtnsTabProductos);
            this.tbpProductos.Controls.Add(this.txtNombre);
            this.tbpProductos.Controls.Add(this.cboCategorias);
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
            this.tbpProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpProductos.Location = new System.Drawing.Point(4, 29);
            this.tbpProductos.Margin = new System.Windows.Forms.Padding(5);
            this.tbpProductos.Name = "tbpProductos";
            this.tbpProductos.Padding = new System.Windows.Forms.Padding(5);
            this.tbpProductos.Size = new System.Drawing.Size(899, 523);
            this.tbpProductos.TabIndex = 0;
            this.tbpProductos.Text = "Productos";
            // 
            // panBtnsTabProductos
            // 
            this.panBtnsTabProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(224)))), ((int)(((byte)(203)))));
            this.panBtnsTabProductos.Controls.Add(this.btnEliminar);
            this.panBtnsTabProductos.Controls.Add(this.btnModificar);
            this.panBtnsTabProductos.Controls.Add(this.btnAgregar);
            this.panBtnsTabProductos.Location = new System.Drawing.Point(563, 25);
            this.panBtnsTabProductos.Name = "panBtnsTabProductos";
            this.panBtnsTabProductos.Size = new System.Drawing.Size(266, 442);
            this.panBtnsTabProductos.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(21, 313);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(224, 91);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(21, 175);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(224, 91);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 38);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(224, 91);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(182, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(344, 27);
            this.txtNombre.TabIndex = 18;
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(182, 442);
            this.cboCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(164, 28);
            this.cboCategorias.Sorted = true;
            this.cboCategorias.TabIndex = 17;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.Color.Black;
            this.lblCategorias.Location = new System.Drawing.Point(69, 442);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(90, 20);
            this.lblCategorias.TabIndex = 11;
            this.lblCategorias.Text = "Categorías";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(182, 383);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(164, 27);
            this.txtStock.TabIndex = 10;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(69, 383);
            this.lblStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 20);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(182, 319);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(164, 27);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(69, 319);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(182, 169);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(344, 103);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(69, 172);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(99, 20);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(69, 115);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(182, 48);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(209, 27);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(69, 55);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(401, 44);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 35);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(2)))));
            this.tbpBuscar.Controls.Add(this.dgvBuscar);
            this.tbpBuscar.Controls.Add(this.matCboCategorias);
            this.tbpBuscar.Controls.Add(this.matTxtCategorias);
            this.tbpBuscar.Controls.Add(this.matLblBuscar);
            this.tbpBuscar.Controls.Add(this.matBtnBuscar);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 29);
            this.tbpBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(5);
            this.tbpBuscar.Size = new System.Drawing.Size(899, 523);
            this.tbpBuscar.TabIndex = 1;
            this.tbpBuscar.Text = "Buscar";
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.descripcion,
            this.precio,
            this.stock,
            this.categoria});
            this.dgvBuscar.Location = new System.Drawing.Point(21, 101);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 51;
            this.dgvBuscar.RowTemplate.Height = 24;
            this.dgvBuscar.Size = new System.Drawing.Size(859, 352);
            this.dgvBuscar.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Width = 75;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.Width = 125;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.Width = 125;
            // 
            // matCboCategorias
            // 
            this.matCboCategorias.AutoResize = false;
            this.matCboCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCboCategorias.Depth = 0;
            this.matCboCategorias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matCboCategorias.DropDownHeight = 174;
            this.matCboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matCboCategorias.DropDownWidth = 121;
            this.matCboCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matCboCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCboCategorias.FormattingEnabled = true;
            this.matCboCategorias.IntegralHeight = false;
            this.matCboCategorias.ItemHeight = 43;
            this.matCboCategorias.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Categoría"});
            this.matCboCategorias.Location = new System.Drawing.Point(131, 31);
            this.matCboCategorias.MaxDropDownItems = 4;
            this.matCboCategorias.MouseState = MaterialSkin.MouseState.OUT;
            this.matCboCategorias.Name = "matCboCategorias";
            this.matCboCategorias.Size = new System.Drawing.Size(258, 49);
            this.matCboCategorias.StartIndex = 0;
            this.matCboCategorias.TabIndex = 3;
            // 
            // matTxtCategorias
            // 
            this.matTxtCategorias.AnimateReadOnly = false;
            this.matTxtCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtCategorias.Depth = 0;
            this.matTxtCategorias.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matTxtCategorias.LeadingIcon = null;
            this.matTxtCategorias.Location = new System.Drawing.Point(404, 32);
            this.matTxtCategorias.MaxLength = 50;
            this.matTxtCategorias.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtCategorias.Multiline = false;
            this.matTxtCategorias.Name = "matTxtCategorias";
            this.matTxtCategorias.Size = new System.Drawing.Size(290, 50);
            this.matTxtCategorias.TabIndex = 2;
            this.matTxtCategorias.Text = "";
            this.matTxtCategorias.TrailingIcon = null;
            // 
            // matLblBuscar
            // 
            this.matLblBuscar.AutoSize = true;
            this.matLblBuscar.Depth = 0;
            this.matLblBuscar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matLblBuscar.Location = new System.Drawing.Point(28, 46);
            this.matLblBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matLblBuscar.Name = "matLblBuscar";
            this.matLblBuscar.Size = new System.Drawing.Size(82, 19);
            this.matLblBuscar.TabIndex = 1;
            this.matLblBuscar.Text = "Buscar Por:";
            // 
            // matBtnBuscar
            // 
            this.matBtnBuscar.AutoSize = false;
            this.matBtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnBuscar.Depth = 0;
            this.matBtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matBtnBuscar.HighEmphasis = true;
            this.matBtnBuscar.Icon = null;
            this.matBtnBuscar.Location = new System.Drawing.Point(723, 31);
            this.matBtnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnBuscar.Name = "matBtnBuscar";
            this.matBtnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnBuscar.Size = new System.Drawing.Size(143, 49);
            this.matBtnBuscar.TabIndex = 0;
            this.matBtnBuscar.Text = "Buscar";
            this.matBtnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnBuscar.UseAccentColor = false;
            this.matBtnBuscar.UseVisualStyleBackColor = true;
            this.matBtnBuscar.Click += new System.EventHandler(this.matBtnBuscar_Click);
            // 
            // tbpReporteInventario
            // 
            this.tbpReporteInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.tbpReporteInventario.Controls.Add(this.matBtnReporte);
            this.tbpReporteInventario.Controls.Add(this.chart1);
            this.tbpReporteInventario.Location = new System.Drawing.Point(4, 29);
            this.tbpReporteInventario.Margin = new System.Windows.Forms.Padding(5);
            this.tbpReporteInventario.Name = "tbpReporteInventario";
            this.tbpReporteInventario.Size = new System.Drawing.Size(899, 523);
            this.tbpReporteInventario.TabIndex = 2;
            this.tbpReporteInventario.Text = "Reporte de inventario";
            // 
            // matBtnReporte
            // 
            this.matBtnReporte.AutoSize = false;
            this.matBtnReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnReporte.Depth = 0;
            this.matBtnReporte.HighEmphasis = true;
            this.matBtnReporte.Icon = null;
            this.matBtnReporte.Location = new System.Drawing.Point(723, 31);
            this.matBtnReporte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnReporte.Name = "matBtnReporte";
            this.matBtnReporte.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnReporte.Size = new System.Drawing.Size(143, 49);
            this.matBtnReporte.TabIndex = 1;
            this.matBtnReporte.Text = "Generar reporte";
            this.matBtnReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnReporte.UseAccentColor = false;
            this.matBtnReporte.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(38, 101);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(825, 390);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // matBtnDestVentas
            // 
            this.matBtnDestVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnDestVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnDestVentas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnDestVentas.Depth = 0;
            this.matBtnDestVentas.HighEmphasis = true;
            this.matBtnDestVentas.Icon = null;
            this.matBtnDestVentas.Location = new System.Drawing.Point(830, 6);
            this.matBtnDestVentas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnDestVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDestVentas.Name = "matBtnDestVentas";
            this.matBtnDestVentas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnDestVentas.Size = new System.Drawing.Size(107, 36);
            this.matBtnDestVentas.TabIndex = 1;
            this.matBtnDestVentas.Text = "Ir a Ventas";
            this.matBtnDestVentas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnDestVentas.UseAccentColor = false;
            this.matBtnDestVentas.UseVisualStyleBackColor = true;
            this.matBtnDestVentas.Click += new System.EventHandler(this.matBtnDestVentas_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 615);
            this.Controls.Add(this.matBtnDestVentas);
            this.Controls.Add(this.tabFuncionalidades);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de inventario";
            this.Load += new System.EventHandler(this.frmInicio_Load_1);
            this.tabFuncionalidades.ResumeLayout(false);
            this.tbpProductos.ResumeLayout(false);
            this.tbpProductos.PerformLayout();
            this.panBtnsTabProductos.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.tbpReporteInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.TextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton matBtnBuscar;
        private MaterialSkin.Controls.MaterialComboBox matCboCategorias;
        private MaterialSkin.Controls.MaterialTextBox matTxtCategorias;
        private MaterialSkin.Controls.MaterialLabel matLblBuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panBtnsTabProductos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private MaterialSkin.Controls.MaterialButton matBtnReporte;
        private MaterialSkin.Controls.MaterialButton matBtnDestVentas;
    }
}