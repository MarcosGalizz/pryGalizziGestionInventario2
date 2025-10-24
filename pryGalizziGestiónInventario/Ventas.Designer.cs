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
            this.matBtnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.matBtnModificar = new MaterialSkin.Controls.MaterialButton();
            this.matBtnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.dtpCreado = new System.Windows.Forms.DateTimePicker();
            this.dtpCambio = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboPromocion = new System.Windows.Forms.ComboBox();
            this.txtArtViejo = new System.Windows.Forms.TextBox();
            this.txtPrecioMayor = new System.Windows.Forms.TextBox();
            this.txtPrecioMenor = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboRubro = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboTalle = new System.Windows.Forms.ComboBox();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.matBtnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.lblCreado = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.lblArtViejo = new System.Windows.Forms.Label();
            this.lblPrecioMayor = new System.Windows.Forms.Label();
            this.lblPrecioMenor = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTalle = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.matBtnDestInicio = new MaterialSkin.Controls.MaterialButton();
            this.tabFuncionalidadesVentas.SuspendLayout();
            this.tbpArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFuncionalidadesVentas
            // 
            this.tabFuncionalidadesVentas.Controls.Add(this.tbpArticulos);
            this.tabFuncionalidadesVentas.Depth = 0;
            this.tabFuncionalidadesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFuncionalidadesVentas.Location = new System.Drawing.Point(22, 38);
            this.tabFuncionalidadesVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFuncionalidadesVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabFuncionalidadesVentas.Multiline = true;
            this.tabFuncionalidadesVentas.Name = "tabFuncionalidadesVentas";
            this.tabFuncionalidadesVentas.SelectedIndex = 0;
            this.tabFuncionalidadesVentas.Size = new System.Drawing.Size(680, 452);
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
            this.tbpArticulos.Controls.Add(this.cboTalle);
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
            this.tbpArticulos.Controls.Add(this.lblTalle);
            this.tbpArticulos.Controls.Add(this.lblTemporada);
            this.tbpArticulos.Controls.Add(this.lblMarca);
            this.tbpArticulos.Controls.Add(this.lblCodigo);
            this.tbpArticulos.Location = new System.Drawing.Point(4, 26);
            this.tbpArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpArticulos.Name = "tbpArticulos";
            this.tbpArticulos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpArticulos.Size = new System.Drawing.Size(672, 422);
            this.tbpArticulos.TabIndex = 0;
            this.tbpArticulos.Text = "Artículos";
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
            this.matBtnEliminar.Location = new System.Drawing.Point(341, 362);
            this.matBtnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.matBtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnEliminar.Name = "matBtnEliminar";
            this.matBtnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnEliminar.Size = new System.Drawing.Size(296, 46);
            this.matBtnEliminar.TabIndex = 38;
            this.matBtnEliminar.Text = "Eliminar";
            this.matBtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnEliminar.UseAccentColor = false;
            this.matBtnEliminar.UseVisualStyleBackColor = true;
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
            this.matBtnModificar.Location = new System.Drawing.Point(341, 297);
            this.matBtnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.matBtnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnModificar.Name = "matBtnModificar";
            this.matBtnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnModificar.Size = new System.Drawing.Size(296, 46);
            this.matBtnModificar.TabIndex = 37;
            this.matBtnModificar.Text = "Modificar";
            this.matBtnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnModificar.UseAccentColor = false;
            this.matBtnModificar.UseVisualStyleBackColor = true;
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
            this.matBtnAgregar.Location = new System.Drawing.Point(341, 231);
            this.matBtnAgregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.matBtnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnAgregar.Name = "matBtnAgregar";
            this.matBtnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnAgregar.Size = new System.Drawing.Size(296, 46);
            this.matBtnAgregar.TabIndex = 36;
            this.matBtnAgregar.Text = "Agregar";
            this.matBtnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnAgregar.UseAccentColor = false;
            this.matBtnAgregar.UseVisualStyleBackColor = true;
            // 
            // dtpCreado
            // 
            this.dtpCreado.Location = new System.Drawing.Point(433, 176);
            this.dtpCreado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCreado.Name = "dtpCreado";
            this.dtpCreado.Size = new System.Drawing.Size(205, 23);
            this.dtpCreado.TabIndex = 35;
            // 
            // dtpCambio
            // 
            this.dtpCambio.Location = new System.Drawing.Point(433, 137);
            this.dtpCambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCambio.Name = "dtpCambio";
            this.dtpCambio.Size = new System.Drawing.Size(205, 23);
            this.dtpCambio.TabIndex = 34;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(433, 97);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(86, 25);
            this.cboEstado.TabIndex = 33;
            // 
            // cboPromocion
            // 
            this.cboPromocion.FormattingEnabled = true;
            this.cboPromocion.Location = new System.Drawing.Point(433, 54);
            this.cboPromocion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPromocion.Name = "cboPromocion";
            this.cboPromocion.Size = new System.Drawing.Size(86, 25);
            this.cboPromocion.TabIndex = 32;
            // 
            // txtArtViejo
            // 
            this.txtArtViejo.Location = new System.Drawing.Point(433, 16);
            this.txtArtViejo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArtViejo.Name = "txtArtViejo";
            this.txtArtViejo.Size = new System.Drawing.Size(86, 23);
            this.txtArtViejo.TabIndex = 31;
            // 
            // txtPrecioMayor
            // 
            this.txtPrecioMayor.Location = new System.Drawing.Point(104, 374);
            this.txtPrecioMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioMayor.Name = "txtPrecioMayor";
            this.txtPrecioMayor.Size = new System.Drawing.Size(86, 23);
            this.txtPrecioMayor.TabIndex = 30;
            // 
            // txtPrecioMenor
            // 
            this.txtPrecioMenor.Location = new System.Drawing.Point(104, 336);
            this.txtPrecioMenor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioMenor.Name = "txtPrecioMenor";
            this.txtPrecioMenor.Size = new System.Drawing.Size(86, 23);
            this.txtPrecioMenor.TabIndex = 29;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(104, 297);
            this.txtPrecioCosto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(86, 23);
            this.txtPrecioCosto.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 254);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 23);
            this.txtNombre.TabIndex = 27;
            // 
            // cboRubro
            // 
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.Location = new System.Drawing.Point(104, 214);
            this.cboRubro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(86, 25);
            this.cboRubro.TabIndex = 26;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(104, 173);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(86, 25);
            this.cboSexo.TabIndex = 25;
            // 
            // cboTalle
            // 
            this.cboTalle.FormattingEnabled = true;
            this.cboTalle.Location = new System.Drawing.Point(104, 135);
            this.cboTalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTalle.Name = "cboTalle";
            this.cboTalle.Size = new System.Drawing.Size(86, 25);
            this.cboTalle.TabIndex = 24;
            // 
            // cboTemporada
            // 
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(104, 97);
            this.cboTemporada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(86, 25);
            this.cboTemporada.TabIndex = 23;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(104, 54);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(86, 25);
            this.cboMarca.TabIndex = 22;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(104, 16);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 23);
            this.txtCodigo.TabIndex = 21;
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
            this.matBtnBuscar.Location = new System.Drawing.Point(212, 13);
            this.matBtnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.matBtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnBuscar.Name = "matBtnBuscar";
            this.matBtnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnBuscar.Size = new System.Drawing.Size(94, 28);
            this.matBtnBuscar.TabIndex = 20;
            this.matBtnBuscar.Text = "Buscar";
            this.matBtnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnBuscar.UseAccentColor = false;
            this.matBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCreado.Location = new System.Drawing.Point(338, 176);
            this.lblCreado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(54, 17);
            this.lblCreado.TabIndex = 14;
            this.lblCreado.Text = "Creado";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCambio.Location = new System.Drawing.Point(338, 137);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(55, 17);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "Cambio";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEstado.Location = new System.Drawing.Point(338, 99);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPromocion.Location = new System.Drawing.Point(338, 57);
            this.lblPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(75, 17);
            this.lblPromocion.TabIndex = 11;
            this.lblPromocion.Text = "Promoción";
            // 
            // lblArtViejo
            // 
            this.lblArtViejo.AutoSize = true;
            this.lblArtViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtViejo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblArtViejo.Location = new System.Drawing.Point(338, 19);
            this.lblArtViejo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtViejo.Name = "lblArtViejo";
            this.lblArtViejo.Size = new System.Drawing.Size(88, 17);
            this.lblArtViejo.TabIndex = 10;
            this.lblArtViejo.Text = "Artículo viejo";
            // 
            // lblPrecioMayor
            // 
            this.lblPrecioMayor.AutoSize = true;
            this.lblPrecioMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMayor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecioMayor.Location = new System.Drawing.Point(14, 376);
            this.lblPrecioMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioMayor.Name = "lblPrecioMayor";
            this.lblPrecioMayor.Size = new System.Drawing.Size(91, 17);
            this.lblPrecioMayor.TabIndex = 9;
            this.lblPrecioMayor.Text = "Precio mayor";
            // 
            // lblPrecioMenor
            // 
            this.lblPrecioMenor.AutoSize = true;
            this.lblPrecioMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMenor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecioMenor.Location = new System.Drawing.Point(14, 339);
            this.lblPrecioMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioMenor.Name = "lblPrecioMenor";
            this.lblPrecioMenor.Size = new System.Drawing.Size(92, 17);
            this.lblPrecioMenor.TabIndex = 8;
            this.lblPrecioMenor.Text = "Precio menor";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCosto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecioCosto.Location = new System.Drawing.Point(14, 300);
            this.lblPrecioCosto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(86, 17);
            this.lblPrecioCosto.TabIndex = 7;
            this.lblPrecioCosto.Text = "Precio costo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Location = new System.Drawing.Point(14, 257);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRubro.Location = new System.Drawing.Point(14, 216);
            this.lblRubro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(47, 17);
            this.lblRubro.TabIndex = 5;
            this.lblRubro.Text = "Rubro";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSexo.Location = new System.Drawing.Point(14, 176);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 17);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTalle.Location = new System.Drawing.Point(14, 137);
            this.lblTalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(39, 17);
            this.lblTalle.TabIndex = 3;
            this.lblTalle.Text = "Talle";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTemporada.Location = new System.Drawing.Point(14, 99);
            this.lblTemporada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(81, 17);
            this.lblTemporada.TabIndex = 2;
            this.lblTemporada.Text = "Temporada";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMarca.Location = new System.Drawing.Point(14, 57);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigo.Location = new System.Drawing.Point(14, 19);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
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
            this.matBtnDestInicio.Location = new System.Drawing.Point(622, 5);
            this.matBtnDestInicio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.matBtnDestInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDestInicio.Name = "matBtnDestInicio";
            this.matBtnDestInicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtnDestInicio.Size = new System.Drawing.Size(80, 29);
            this.matBtnDestInicio.TabIndex = 2;
            this.matBtnDestInicio.Text = "Ir a Inicio";
            this.matBtnDestInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnDestInicio.UseAccentColor = false;
            this.matBtnDestInicio.UseVisualStyleBackColor = true;
            this.matBtnDestInicio.Click += new System.EventHandler(this.matBtnDestInicio_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 500);
            this.Controls.Add(this.matBtnDestInicio);
            this.Controls.Add(this.tabFuncionalidadesVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblTalle;
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
        private System.Windows.Forms.ComboBox cboTalle;
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