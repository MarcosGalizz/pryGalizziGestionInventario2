namespace pryGalizziGestiónInventario
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.tabFuncionalidadesVentas = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpArticulos = new System.Windows.Forms.TabPage();
            this.matBtnDestInicio = new MaterialSkin.Controls.MaterialButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblAa = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblPrecioMenor = new System.Windows.Forms.Label();
            this.lblPrecioMayor = new System.Windows.Forms.Label();
            this.lblArtViejo = new System.Windows.Forms.Label();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblCreado = new System.Windows.Forms.Label();
            this.matBtnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.cboAa = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboRubro = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtPrecioMenor = new System.Windows.Forms.TextBox();
            this.txtPrecioMayor = new System.Windows.Forms.TextBox();
            this.txtArtViejo = new System.Windows.Forms.TextBox();
            this.cboPromocion = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dtpCambio = new System.Windows.Forms.DateTimePicker();
            this.dtpCreado = new System.Windows.Forms.DateTimePicker();
            this.matBtnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.matBtnModificar = new MaterialSkin.Controls.MaterialButton();
            this.matBtnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.tabFuncionalidadesVentas.SuspendLayout();
            this.tbpArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFuncionalidadesVentas
            // 
            this.tabFuncionalidadesVentas.Controls.Add(this.tbpArticulos);
            this.tabFuncionalidadesVentas.Depth = 0;
            this.tabFuncionalidadesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFuncionalidadesVentas.Location = new System.Drawing.Point(30, 47);
            this.tabFuncionalidadesVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabFuncionalidadesVentas.Multiline = true;
            this.tabFuncionalidadesVentas.Name = "tabFuncionalidadesVentas";
            this.tabFuncionalidadesVentas.SelectedIndex = 0;
            this.tabFuncionalidadesVentas.Size = new System.Drawing.Size(907, 556);
            this.tabFuncionalidadesVentas.TabIndex = 1;
            // 
            // tbpArticulos
            // 
            this.tbpArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(81)))));
            this.tbpArticulos.Controls.Add(this.matBtnEliminar);
            this.tbpArticulos.Controls.Add(this.matBtnModificar);
            this.tbpArticulos.Controls.Add(this.matBtnAgregar);
            this.tbpArticulos.Controls.Add(this.dtpCreado);
            this.tbpArticulos.Controls.Add(this.dtpCambio);
            this.tbpArticulos.Controls.Add(this.cboEstado);
            this.tbpArticulos.Controls.Add(this.cboPromocion);
            this.tbpArticulos.Controls.Add(this.txtArtViejo);
            this.tbpArticulos.Controls.Add(this.txtPrecioMayor);
            this.tbpArticulos.Controls.Add(this.txtPrecioMenor);
            this.tbpArticulos.Controls.Add(this.txtPrecioCosto);
            this.tbpArticulos.Controls.Add(this.txtNombre);
            this.tbpArticulos.Controls.Add(this.cboRubro);
            this.tbpArticulos.Controls.Add(this.cboSexo);
            this.tbpArticulos.Controls.Add(this.cboAa);
            this.tbpArticulos.Controls.Add(this.cboTemporada);
            this.tbpArticulos.Controls.Add(this.cboMarca);
            this.tbpArticulos.Controls.Add(this.txtCodigo);
            this.tbpArticulos.Controls.Add(this.matBtnBuscar);
            this.tbpArticulos.Controls.Add(this.lblCreado);
            this.tbpArticulos.Controls.Add(this.lblCambio);
            this.tbpArticulos.Controls.Add(this.lblEstado);
            this.tbpArticulos.Controls.Add(this.lblPromocion);
            this.tbpArticulos.Controls.Add(this.lblArtViejo);
            this.tbpArticulos.Controls.Add(this.lblPrecioMayor);
            this.tbpArticulos.Controls.Add(this.lblPrecioMenor);
            this.tbpArticulos.Controls.Add(this.lblPrecioCosto);
            this.tbpArticulos.Controls.Add(this.lblNombre);
            this.tbpArticulos.Controls.Add(this.lblRubro);
            this.tbpArticulos.Controls.Add(this.lblSexo);
            this.tbpArticulos.Controls.Add(this.lblAa);
            this.tbpArticulos.Controls.Add(this.lblTemporada);
            this.tbpArticulos.Controls.Add(this.lblMarca);
            this.tbpArticulos.Controls.Add(this.lblCodigo);
            this.tbpArticulos.Location = new System.Drawing.Point(4, 29);
            this.tbpArticulos.Name = "tbpArticulos";
            this.tbpArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArticulos.Size = new System.Drawing.Size(899, 523);
            this.tbpArticulos.TabIndex = 0;
            this.tbpArticulos.Text = "Artículos";
            // 
            // matBtnDestInicio
            // 
            this.matBtnDestInicio.AutoSize = false;
            this.matBtnDestInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnDestInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnDestInicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnDestInicio.Depth = 0;
            this.matBtnDestInicio.HighEmphasis = true;
            this.matBtnDestInicio.Icon = null;
            this.matBtnDestInicio.Location = new System.Drawing.Point(830, 6);
            this.matBtnDestInicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnDestInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDestInicio.Name = "matBtnDestInicio";
            this.matBtnDestInicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnDestInicio.Size = new System.Drawing.Size(107, 36);
            this.matBtnDestInicio.TabIndex = 2;
            this.matBtnDestInicio.Text = "Ir a Inicio";
            this.matBtnDestInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnDestInicio.UseAccentColor = false;
            this.matBtnDestInicio.UseVisualStyleBackColor = true;
            this.matBtnDestInicio.Click += new System.EventHandler(this.matBtnDestInicio_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigo.Location = new System.Drawing.Point(18, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMarca.Location = new System.Drawing.Point(18, 70);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 20);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTemporada.Location = new System.Drawing.Point(18, 122);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(93, 20);
            this.lblTemporada.TabIndex = 2;
            this.lblTemporada.Text = "Temporada";
            // 
            // lblAa
            // 
            this.lblAa.AutoSize = true;
            this.lblAa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAa.Location = new System.Drawing.Point(18, 169);
            this.lblAa.Name = "lblAa";
            this.lblAa.Size = new System.Drawing.Size(27, 20);
            this.lblAa.TabIndex = 3;
            this.lblAa.Text = "aa";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSexo.Location = new System.Drawing.Point(18, 216);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 20);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRubro.Location = new System.Drawing.Point(18, 266);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(54, 20);
            this.lblRubro.TabIndex = 5;
            this.lblRubro.Text = "Rubro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Location = new System.Drawing.Point(18, 316);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCosto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecioCosto.Location = new System.Drawing.Point(18, 369);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(103, 20);
            this.lblPrecioCosto.TabIndex = 7;
            this.lblPrecioCosto.Text = "Precio costo";
            // 
            // lblPrecioMenor
            // 
            this.lblPrecioMenor.AutoSize = true;
            this.lblPrecioMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMenor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecioMenor.Location = new System.Drawing.Point(18, 417);
            this.lblPrecioMenor.Name = "lblPrecioMenor";
            this.lblPrecioMenor.Size = new System.Drawing.Size(109, 20);
            this.lblPrecioMenor.TabIndex = 8;
            this.lblPrecioMenor.Text = "Precio menor";
            // 
            // lblPrecioMayor
            // 
            this.lblPrecioMayor.AutoSize = true;
            this.lblPrecioMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMayor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecioMayor.Location = new System.Drawing.Point(18, 463);
            this.lblPrecioMayor.Name = "lblPrecioMayor";
            this.lblPrecioMayor.Size = new System.Drawing.Size(108, 20);
            this.lblPrecioMayor.TabIndex = 9;
            this.lblPrecioMayor.Text = "Precio mayor";
            // 
            // lblArtViejo
            // 
            this.lblArtViejo.AutoSize = true;
            this.lblArtViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtViejo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblArtViejo.Location = new System.Drawing.Point(451, 23);
            this.lblArtViejo.Name = "lblArtViejo";
            this.lblArtViejo.Size = new System.Drawing.Size(105, 20);
            this.lblArtViejo.TabIndex = 10;
            this.lblArtViejo.Text = "Artículo viejo";
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPromocion.Location = new System.Drawing.Point(451, 70);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(89, 20);
            this.lblPromocion.TabIndex = 11;
            this.lblPromocion.Text = "Promoción";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEstado.Location = new System.Drawing.Point(451, 122);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 20);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCambio.Location = new System.Drawing.Point(451, 169);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(66, 20);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "Cambio";
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCreado.Location = new System.Drawing.Point(451, 216);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(63, 20);
            this.lblCreado.TabIndex = 14;
            this.lblCreado.Text = "Creado";
            // 
            // matBtnBuscar
            // 
            this.matBtnBuscar.AutoSize = false;
            this.matBtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnBuscar.Depth = 0;
            this.matBtnBuscar.HighEmphasis = true;
            this.matBtnBuscar.Icon = null;
            this.matBtnBuscar.Location = new System.Drawing.Point(283, 16);
            this.matBtnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnBuscar.Name = "matBtnBuscar";
            this.matBtnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnBuscar.Size = new System.Drawing.Size(125, 35);
            this.matBtnBuscar.TabIndex = 20;
            this.matBtnBuscar.Text = "Buscar";
            this.matBtnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnBuscar.UseAccentColor = false;
            this.matBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(113, 27);
            this.txtCodigo.TabIndex = 21;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(139, 67);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(113, 28);
            this.cboMarca.TabIndex = 22;
            // 
            // cboTemporada
            // 
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(139, 119);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(113, 28);
            this.cboTemporada.TabIndex = 23;
            // 
            // cboAa
            // 
            this.cboAa.FormattingEnabled = true;
            this.cboAa.Location = new System.Drawing.Point(139, 166);
            this.cboAa.Name = "cboAa";
            this.cboAa.Size = new System.Drawing.Size(113, 28);
            this.cboAa.TabIndex = 24;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(139, 213);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(113, 28);
            this.cboSexo.TabIndex = 25;
            // 
            // cboRubro
            // 
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.Location = new System.Drawing.Point(139, 263);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(113, 28);
            this.cboRubro.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 313);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 27);
            this.txtNombre.TabIndex = 27;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(139, 366);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(113, 27);
            this.txtPrecioCosto.TabIndex = 28;
            // 
            // txtPrecioMenor
            // 
            this.txtPrecioMenor.Location = new System.Drawing.Point(139, 414);
            this.txtPrecioMenor.Name = "txtPrecioMenor";
            this.txtPrecioMenor.Size = new System.Drawing.Size(113, 27);
            this.txtPrecioMenor.TabIndex = 29;
            // 
            // txtPrecioMayor
            // 
            this.txtPrecioMayor.Location = new System.Drawing.Point(139, 460);
            this.txtPrecioMayor.Name = "txtPrecioMayor";
            this.txtPrecioMayor.Size = new System.Drawing.Size(113, 27);
            this.txtPrecioMayor.TabIndex = 30;
            // 
            // txtArtViejo
            // 
            this.txtArtViejo.Location = new System.Drawing.Point(577, 20);
            this.txtArtViejo.Name = "txtArtViejo";
            this.txtArtViejo.Size = new System.Drawing.Size(113, 27);
            this.txtArtViejo.TabIndex = 31;
            // 
            // cboPromocion
            // 
            this.cboPromocion.FormattingEnabled = true;
            this.cboPromocion.Location = new System.Drawing.Point(577, 67);
            this.cboPromocion.Name = "cboPromocion";
            this.cboPromocion.Size = new System.Drawing.Size(113, 28);
            this.cboPromocion.TabIndex = 32;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(577, 119);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(113, 28);
            this.cboEstado.TabIndex = 33;
            // 
            // dtpCambio
            // 
            this.dtpCambio.Location = new System.Drawing.Point(577, 169);
            this.dtpCambio.Name = "dtpCambio";
            this.dtpCambio.Size = new System.Drawing.Size(272, 27);
            this.dtpCambio.TabIndex = 34;
            // 
            // dtpCreado
            // 
            this.dtpCreado.Location = new System.Drawing.Point(577, 216);
            this.dtpCreado.Name = "dtpCreado";
            this.dtpCreado.Size = new System.Drawing.Size(272, 27);
            this.dtpCreado.TabIndex = 35;
            // 
            // matBtnAgregar
            // 
            this.matBtnAgregar.AutoSize = false;
            this.matBtnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnAgregar.Depth = 0;
            this.matBtnAgregar.HighEmphasis = true;
            this.matBtnAgregar.Icon = null;
            this.matBtnAgregar.Location = new System.Drawing.Point(455, 284);
            this.matBtnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnAgregar.Name = "matBtnAgregar";
            this.matBtnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnAgregar.Size = new System.Drawing.Size(394, 56);
            this.matBtnAgregar.TabIndex = 36;
            this.matBtnAgregar.Text = "Agregar";
            this.matBtnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnAgregar.UseAccentColor = false;
            this.matBtnAgregar.UseVisualStyleBackColor = true;
            // 
            // matBtnModificar
            // 
            this.matBtnModificar.AutoSize = false;
            this.matBtnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnModificar.Depth = 0;
            this.matBtnModificar.HighEmphasis = true;
            this.matBtnModificar.Icon = null;
            this.matBtnModificar.Location = new System.Drawing.Point(455, 366);
            this.matBtnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnModificar.Name = "matBtnModificar";
            this.matBtnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnModificar.Size = new System.Drawing.Size(394, 56);
            this.matBtnModificar.TabIndex = 37;
            this.matBtnModificar.Text = "Modificar";
            this.matBtnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnModificar.UseAccentColor = false;
            this.matBtnModificar.UseVisualStyleBackColor = true;
            // 
            // matBtnEliminar
            // 
            this.matBtnEliminar.AutoSize = false;
            this.matBtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matBtnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtnEliminar.Depth = 0;
            this.matBtnEliminar.HighEmphasis = true;
            this.matBtnEliminar.Icon = null;
            this.matBtnEliminar.Location = new System.Drawing.Point(455, 445);
            this.matBtnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnEliminar.Name = "matBtnEliminar";
            this.matBtnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnEliminar.Size = new System.Drawing.Size(394, 56);
            this.matBtnEliminar.TabIndex = 38;
            this.matBtnEliminar.Text = "Eliminar";
            this.matBtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnEliminar.UseAccentColor = false;
            this.matBtnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 615);
            this.Controls.Add(this.matBtnDestInicio);
            this.Controls.Add(this.tabFuncionalidadesVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.tabFuncionalidadesVentas.ResumeLayout(false);
            this.tbpArticulos.ResumeLayout(false);
            this.tbpArticulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabFuncionalidadesVentas;
        private System.Windows.Forms.TabPage tbpArticulos;
        private MaterialSkin.Controls.MaterialButton matBtnDestInicio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblAa;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.Label lblArtViejo;
        private System.Windows.Forms.Label lblPrecioMayor;
        private System.Windows.Forms.Label lblPrecioMenor;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblNombre;
        private MaterialSkin.Controls.MaterialButton matBtnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtPrecioMayor;
        private System.Windows.Forms.TextBox txtPrecioMenor;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboRubro;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.ComboBox cboAa;
        private System.Windows.Forms.ComboBox cboTemporada;
        private System.Windows.Forms.DateTimePicker dtpCreado;
        private System.Windows.Forms.DateTimePicker dtpCambio;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboPromocion;
        private System.Windows.Forms.TextBox txtArtViejo;
        private MaterialSkin.Controls.MaterialButton matBtnEliminar;
        private MaterialSkin.Controls.MaterialButton matBtnModificar;
        private MaterialSkin.Controls.MaterialButton matBtnAgregar;
    }
}