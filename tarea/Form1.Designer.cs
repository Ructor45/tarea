namespace tarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rut = new Label();
            nombre = new Label();
            esempresa = new Label();
            telefono = new Label();
            direccion = new Label();
            fecharegistro = new Label();
            cantidadfactura = new Label();
            numeroultimafactura = new Label();
            montoultimafactura = new Label();
            txtrut = new TextBox();
            txtnombre = new TextBox();
            txttelefono = new TextBox();
            txtdirecion = new TextBox();
            txtcantidadfacturas = new TextBox();
            txtnumeroultimafactura = new TextBox();
            txtmontoultimafactura = new TextBox();
            rbt1 = new RadioButton();
            rbt2 = new RadioButton();
            dtpfecharegistro = new DateTimePicker();
            dataGridView1 = new DataGridView();
            rutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            esEmpresaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaRegistroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadFacturasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroUltimaFacturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoUltimaFacturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource1 = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            btnagregar = new Button();
            clienteControllerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // rut
            // 
            rut.AutoSize = true;
            rut.Location = new Point(24, 20);
            rut.Name = "rut";
            rut.Size = new Size(31, 20);
            rut.TabIndex = 0;
            rut.Text = "Rut";
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(24, 73);
            nombre.Name = "nombre";
            nombre.Size = new Size(64, 20);
            nombre.TabIndex = 1;
            nombre.Text = "Nombre";
            // 
            // esempresa
            // 
            esempresa.AutoSize = true;
            esempresa.Location = new Point(24, 119);
            esempresa.Name = "esempresa";
            esempresa.Size = new Size(80, 20);
            esempresa.TabIndex = 2;
            esempresa.Text = "EsEmpresa";
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Location = new Point(21, 164);
            telefono.Name = "telefono";
            telefono.Size = new Size(67, 20);
            telefono.TabIndex = 3;
            telefono.Text = "Telefono";
            telefono.Click += label4_Click;
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Location = new Point(24, 204);
            direccion.Name = "direccion";
            direccion.Size = new Size(72, 20);
            direccion.TabIndex = 4;
            direccion.Text = "Direccion";
            // 
            // fecharegistro
            // 
            fecharegistro.AutoSize = true;
            fecharegistro.Location = new Point(24, 249);
            fecharegistro.Name = "fecharegistro";
            fecharegistro.Size = new Size(102, 20);
            fecharegistro.TabIndex = 5;
            fecharegistro.Text = "FechaRegistro";
            // 
            // cantidadfactura
            // 
            cantidadfactura.AutoSize = true;
            cantidadfactura.Location = new Point(24, 294);
            cantidadfactura.Name = "cantidadfactura";
            cantidadfactura.Size = new Size(122, 20);
            cantidadfactura.TabIndex = 6;
            cantidadfactura.Text = "CantidadFacturas";
            // 
            // numeroultimafactura
            // 
            numeroultimafactura.AutoSize = true;
            numeroultimafactura.Location = new Point(24, 340);
            numeroultimafactura.Name = "numeroultimafactura";
            numeroultimafactura.Size = new Size(154, 20);
            numeroultimafactura.TabIndex = 7;
            numeroultimafactura.Text = "NumeroUltimaFactura";
            // 
            // montoultimafactura
            // 
            montoultimafactura.AutoSize = true;
            montoultimafactura.Location = new Point(24, 389);
            montoultimafactura.Name = "montoultimafactura";
            montoultimafactura.Size = new Size(144, 20);
            montoultimafactura.TabIndex = 8;
            montoultimafactura.Text = "MontoUltimaFactura";
            montoultimafactura.Click += label9_Click;
            // 
            // txtrut
            // 
            txtrut.Location = new Point(256, 20);
            txtrut.Multiline = true;
            txtrut.Name = "txtrut";
            txtrut.Size = new Size(125, 27);
            txtrut.TabIndex = 9;
            txtrut.TextChanged += txtrut_TextChanged;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(256, 66);
            txtnombre.Multiline = true;
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 10;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(256, 161);
            txttelefono.Multiline = true;
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(125, 27);
            txttelefono.TabIndex = 11;
            // 
            // txtdirecion
            // 
            txtdirecion.Location = new Point(256, 197);
            txtdirecion.Multiline = true;
            txtdirecion.Name = "txtdirecion";
            txtdirecion.Size = new Size(125, 27);
            txtdirecion.TabIndex = 12;
            // 
            // txtcantidadfacturas
            // 
            txtcantidadfacturas.Location = new Point(256, 287);
            txtcantidadfacturas.Multiline = true;
            txtcantidadfacturas.Name = "txtcantidadfacturas";
            txtcantidadfacturas.Size = new Size(125, 27);
            txtcantidadfacturas.TabIndex = 13;
            // 
            // txtnumeroultimafactura
            // 
            txtnumeroultimafactura.Location = new Point(256, 333);
            txtnumeroultimafactura.Multiline = true;
            txtnumeroultimafactura.Name = "txtnumeroultimafactura";
            txtnumeroultimafactura.Size = new Size(125, 27);
            txtnumeroultimafactura.TabIndex = 14;
            // 
            // txtmontoultimafactura
            // 
            txtmontoultimafactura.Location = new Point(256, 386);
            txtmontoultimafactura.Multiline = true;
            txtmontoultimafactura.Name = "txtmontoultimafactura";
            txtmontoultimafactura.Size = new Size(125, 27);
            txtmontoultimafactura.TabIndex = 15;
            // 
            // rbt1
            // 
            rbt1.AutoSize = true;
            rbt1.Location = new Point(256, 115);
            rbt1.Name = "rbt1";
            rbt1.Size = new Size(40, 24);
            rbt1.TabIndex = 16;
            rbt1.TabStop = true;
            rbt1.Text = "si";
            rbt1.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            rbt2.AutoSize = true;
            rbt2.Location = new Point(317, 117);
            rbt2.Name = "rbt2";
            rbt2.Size = new Size(47, 24);
            rbt2.TabIndex = 17;
            rbt2.TabStop = true;
            rbt2.Text = "no";
            rbt2.UseVisualStyleBackColor = true;
            // 
            // dtpfecharegistro
            // 
            dtpfecharegistro.Location = new Point(234, 249);
            dtpfecharegistro.Name = "dtpfecharegistro";
            dtpfecharegistro.Size = new Size(278, 27);
            dtpfecharegistro.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { rutDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, esEmpresaDataGridViewCheckBoxColumn, telefonoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, fechaRegistroDataGridViewTextBoxColumn, cantidadFacturasDataGridViewTextBoxColumn, numeroUltimaFacturaDataGridViewTextBoxColumn, montoUltimaFacturaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource1;
            dataGridView1.Location = new Point(533, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1056, 490);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            rutDataGridViewTextBoxColumn.DataPropertyName = "Rut";
            rutDataGridViewTextBoxColumn.HeaderText = "Rut";
            rutDataGridViewTextBoxColumn.MinimumWidth = 6;
            rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            rutDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // esEmpresaDataGridViewCheckBoxColumn
            // 
            esEmpresaDataGridViewCheckBoxColumn.DataPropertyName = "EsEmpresa";
            esEmpresaDataGridViewCheckBoxColumn.HeaderText = "EsEmpresa";
            esEmpresaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            esEmpresaDataGridViewCheckBoxColumn.Name = "esEmpresaDataGridViewCheckBoxColumn";
            esEmpresaDataGridViewCheckBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            fechaRegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            fechaRegistroDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadFacturasDataGridViewTextBoxColumn
            // 
            cantidadFacturasDataGridViewTextBoxColumn.DataPropertyName = "CantidadFacturas";
            cantidadFacturasDataGridViewTextBoxColumn.HeaderText = "CantidadFacturas";
            cantidadFacturasDataGridViewTextBoxColumn.MinimumWidth = 6;
            cantidadFacturasDataGridViewTextBoxColumn.Name = "cantidadFacturasDataGridViewTextBoxColumn";
            cantidadFacturasDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroUltimaFacturaDataGridViewTextBoxColumn
            // 
            numeroUltimaFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroUltimaFactura";
            numeroUltimaFacturaDataGridViewTextBoxColumn.HeaderText = "NumeroUltimaFactura";
            numeroUltimaFacturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            numeroUltimaFacturaDataGridViewTextBoxColumn.Name = "numeroUltimaFacturaDataGridViewTextBoxColumn";
            numeroUltimaFacturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoUltimaFacturaDataGridViewTextBoxColumn
            // 
            montoUltimaFacturaDataGridViewTextBoxColumn.DataPropertyName = "MontoUltimaFactura";
            montoUltimaFacturaDataGridViewTextBoxColumn.HeaderText = "MontoUltimaFactura";
            montoUltimaFacturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            montoUltimaFacturaDataGridViewTextBoxColumn.Name = "montoUltimaFacturaDataGridViewTextBoxColumn";
            montoUltimaFacturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(Models.Cliente);
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(270, 484);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(94, 29);
            btnagregar.TabIndex = 20;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // clienteControllerBindingSource
            // 
            clienteControllerBindingSource.DataSource = typeof(Controllers.ClienteController);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1744, 681);
            Controls.Add(dataGridView1);
            Controls.Add(btnagregar);
            Controls.Add(dtpfecharegistro);
            Controls.Add(rbt2);
            Controls.Add(rbt1);
            Controls.Add(txtmontoultimafactura);
            Controls.Add(txtnumeroultimafactura);
            Controls.Add(txtcantidadfacturas);
            Controls.Add(txtdirecion);
            Controls.Add(txttelefono);
            Controls.Add(txtnombre);
            Controls.Add(txtrut);
            Controls.Add(montoultimafactura);
            Controls.Add(numeroultimafactura);
            Controls.Add(cantidadfactura);
            Controls.Add(fecharegistro);
            Controls.Add(direccion);
            Controls.Add(telefono);
            Controls.Add(esempresa);
            Controls.Add(nombre);
            Controls.Add(rut);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rut;
        private Label nombre;
        private Label esempresa;
        private Label telefono;
        private Label direccion;
        private Label fecharegistro;
        private Label cantidadfactura;
        private Label numeroultimafactura;
        private Label montoultimafactura;
        private TextBox txtrut;
        private TextBox txtnombre;
        private TextBox txttelefono;
        private TextBox txtdirecion;
        private TextBox txtcantidadfacturas;
        private TextBox txtnumeroultimafactura;
        private TextBox txtmontoultimafactura;
        private RadioButton rbt1;
        private RadioButton rbt2;
        private DateTimePicker dtpfecharegistro;
        private DataGridView dataGridView1;
        private Button btnagregar;
        private DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn esEmpresaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadFacturasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroUltimaFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoUltimaFacturaDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private BindingSource clienteControllerBindingSource;
        private BindingSource clienteBindingSource1;
    }
}