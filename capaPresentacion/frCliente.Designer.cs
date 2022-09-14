namespace capaPresentacion
{
    partial class frCliente
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
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.pgRegistrar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pgActualizar = new System.Windows.Forms.TabPage();
            this.inCliente = new System.Windows.Forms.Label();
            this.pgConsultar = new System.Windows.Forms.TabPage();
            this.pgEliminar = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbConsultar = new System.Windows.Forms.RadioButton();
            this.rbActualizar = new System.Windows.Forms.RadioButton();
            this.rbRegistrar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRDocumento = new System.Windows.Forms.TextBox();
            this.txtRNombre = new System.Windows.Forms.TextBox();
            this.txtRDireccion = new System.Windows.Forms.TextBox();
            this.txtRTelefono = new System.Windows.Forms.TextBox();
            this.txtRCorreo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listActualizar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtADocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtANombre = new System.Windows.Forms.TextBox();
            this.txtADireccion = new System.Windows.Forms.TextBox();
            this.txtATelefono = new System.Windows.Forms.TextBox();
            this.txtACorreo = new System.Windows.Forms.TextBox();
            this.dtgACliente = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.listConsultar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgConsultar = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listEliminar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.pgRegistrar.SuspendLayout();
            this.pgActualizar.SuspendLayout();
            this.pgConsultar.SuspendLayout();
            this.pgEliminar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgACliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.pgRegistrar);
            this.tabControlPrincipal.Controls.Add(this.pgActualizar);
            this.tabControlPrincipal.Controls.Add(this.pgConsultar);
            this.tabControlPrincipal.Controls.Add(this.pgEliminar);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // pgRegistrar
            // 
            this.pgRegistrar.Controls.Add(this.label9);
            this.pgRegistrar.Controls.Add(this.btnRLimpiar);
            this.pgRegistrar.Controls.Add(this.btnAgregar);
            this.pgRegistrar.Controls.Add(this.txtRCorreo);
            this.pgRegistrar.Controls.Add(this.txtRTelefono);
            this.pgRegistrar.Controls.Add(this.txtRDireccion);
            this.pgRegistrar.Controls.Add(this.txtRNombre);
            this.pgRegistrar.Controls.Add(this.txtRDocumento);
            this.pgRegistrar.Controls.Add(this.label8);
            this.pgRegistrar.Controls.Add(this.label7);
            this.pgRegistrar.Controls.Add(this.label6);
            this.pgRegistrar.Controls.Add(this.label5);
            this.pgRegistrar.Controls.Add(this.label1);
            this.pgRegistrar.Location = new System.Drawing.Point(4, 30);
            this.pgRegistrar.Name = "pgRegistrar";
            this.pgRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.pgRegistrar.Size = new System.Drawing.Size(792, 416);
            this.pgRegistrar.TabIndex = 0;
            this.pgRegistrar.Text = "tabPage1";
            this.pgRegistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hug Me Tight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // pgActualizar
            // 
            this.pgActualizar.Controls.Add(this.dtgACliente);
            this.pgActualizar.Controls.Add(this.txtACorreo);
            this.pgActualizar.Controls.Add(this.txtATelefono);
            this.pgActualizar.Controls.Add(this.txtADireccion);
            this.pgActualizar.Controls.Add(this.txtANombre);
            this.pgActualizar.Controls.Add(this.btnActualizar);
            this.pgActualizar.Controls.Add(this.txtADocumento);
            this.pgActualizar.Controls.Add(this.label2);
            this.pgActualizar.Controls.Add(this.label10);
            this.pgActualizar.Controls.Add(this.label11);
            this.pgActualizar.Controls.Add(this.label12);
            this.pgActualizar.Controls.Add(this.label13);
            this.pgActualizar.Controls.Add(this.btnBuscar);
            this.pgActualizar.Controls.Add(this.listActualizar);
            this.pgActualizar.Controls.Add(this.inCliente);
            this.pgActualizar.Location = new System.Drawing.Point(4, 30);
            this.pgActualizar.Name = "pgActualizar";
            this.pgActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.pgActualizar.Size = new System.Drawing.Size(792, 416);
            this.pgActualizar.TabIndex = 1;
            this.pgActualizar.Text = "tabPage2";
            this.pgActualizar.UseVisualStyleBackColor = true;
            // 
            // inCliente
            // 
            this.inCliente.AutoSize = true;
            this.inCliente.Font = new System.Drawing.Font("Hug Me Tight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inCliente.Location = new System.Drawing.Point(114, 89);
            this.inCliente.Name = "inCliente";
            this.inCliente.Size = new System.Drawing.Size(85, 26);
            this.inCliente.TabIndex = 1;
            this.inCliente.Text = "Cliente";
            // 
            // pgConsultar
            // 
            this.pgConsultar.Controls.Add(this.dtgConsultar);
            this.pgConsultar.Controls.Add(this.btnConsultar);
            this.pgConsultar.Controls.Add(this.listConsultar);
            this.pgConsultar.Controls.Add(this.label3);
            this.pgConsultar.Location = new System.Drawing.Point(4, 30);
            this.pgConsultar.Name = "pgConsultar";
            this.pgConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.pgConsultar.Size = new System.Drawing.Size(792, 416);
            this.pgConsultar.TabIndex = 2;
            this.pgConsultar.Text = "tabPage3";
            this.pgConsultar.UseVisualStyleBackColor = true;
            // 
            // pgEliminar
            // 
            this.pgEliminar.Controls.Add(this.btnEliminar);
            this.pgEliminar.Controls.Add(this.listEliminar);
            this.pgEliminar.Controls.Add(this.label4);
            this.pgEliminar.Location = new System.Drawing.Point(4, 30);
            this.pgEliminar.Name = "pgEliminar";
            this.pgEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.pgEliminar.Size = new System.Drawing.Size(792, 416);
            this.pgEliminar.TabIndex = 3;
            this.pgEliminar.Text = "tabPage4";
            this.pgEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.rbEliminar);
            this.panel1.Controls.Add(this.rbConsultar);
            this.panel1.Controls.Add(this.rbActualizar);
            this.panel1.Controls.Add(this.rbRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 51);
            this.panel1.TabIndex = 2;
            // 
            // rbEliminar
            // 
            this.rbEliminar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbEliminar.Location = new System.Drawing.Point(288, 12);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(77, 31);
            this.rbEliminar.TabIndex = 3;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = false;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // rbConsultar
            // 
            this.rbConsultar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbConsultar.AutoSize = true;
            this.rbConsultar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbConsultar.Location = new System.Drawing.Point(195, 12);
            this.rbConsultar.Name = "rbConsultar";
            this.rbConsultar.Size = new System.Drawing.Size(87, 31);
            this.rbConsultar.TabIndex = 2;
            this.rbConsultar.TabStop = true;
            this.rbConsultar.Text = "Consultar";
            this.rbConsultar.UseVisualStyleBackColor = false;
            this.rbConsultar.CheckedChanged += new System.EventHandler(this.rbConsultar_CheckedChanged);
            // 
            // rbActualizar
            // 
            this.rbActualizar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbActualizar.AutoSize = true;
            this.rbActualizar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbActualizar.Location = new System.Drawing.Point(101, 12);
            this.rbActualizar.Name = "rbActualizar";
            this.rbActualizar.Size = new System.Drawing.Size(88, 31);
            this.rbActualizar.TabIndex = 1;
            this.rbActualizar.TabStop = true;
            this.rbActualizar.Text = "Actualizar";
            this.rbActualizar.UseVisualStyleBackColor = false;
            this.rbActualizar.CheckedChanged += new System.EventHandler(this.rbActualizar_CheckedChanged);
            // 
            // rbRegistrar
            // 
            this.rbRegistrar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRegistrar.AutoSize = true;
            this.rbRegistrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbRegistrar.Location = new System.Drawing.Point(12, 12);
            this.rbRegistrar.Name = "rbRegistrar";
            this.rbRegistrar.Size = new System.Drawing.Size(83, 31);
            this.rbRegistrar.TabIndex = 0;
            this.rbRegistrar.TabStop = true;
            this.rbRegistrar.Text = "Registrar";
            this.rbRegistrar.UseVisualStyleBackColor = false;
            this.rbRegistrar.CheckedChanged += new System.EventHandler(this.rbRegistrar_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hug Me Tight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(231, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hug Me Tight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(231, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hug Me Tight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(231, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hug Me Tight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(234, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Correo:";
            // 
            // txtRDocumento
            // 
            this.txtRDocumento.Location = new System.Drawing.Point(374, 127);
            this.txtRDocumento.Name = "txtRDocumento";
            this.txtRDocumento.Size = new System.Drawing.Size(174, 29);
            this.txtRDocumento.TabIndex = 5;
            // 
            // txtRNombre
            // 
            this.txtRNombre.Location = new System.Drawing.Point(374, 171);
            this.txtRNombre.Name = "txtRNombre";
            this.txtRNombre.Size = new System.Drawing.Size(174, 29);
            this.txtRNombre.TabIndex = 6;
            // 
            // txtRDireccion
            // 
            this.txtRDireccion.Location = new System.Drawing.Point(374, 217);
            this.txtRDireccion.Name = "txtRDireccion";
            this.txtRDireccion.Size = new System.Drawing.Size(174, 29);
            this.txtRDireccion.TabIndex = 7;
            // 
            // txtRTelefono
            // 
            this.txtRTelefono.Location = new System.Drawing.Point(374, 259);
            this.txtRTelefono.Name = "txtRTelefono";
            this.txtRTelefono.Size = new System.Drawing.Size(174, 29);
            this.txtRTelefono.TabIndex = 8;
            // 
            // txtRCorreo
            // 
            this.txtRCorreo.Location = new System.Drawing.Point(374, 300);
            this.txtRCorreo.Name = "txtRCorreo";
            this.txtRCorreo.Size = new System.Drawing.Size(174, 29);
            this.txtRCorreo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(463, 357);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRLimpiar
            // 
            this.btnRLimpiar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRLimpiar.Location = new System.Drawing.Point(286, 357);
            this.btnRLimpiar.Name = "btnRLimpiar";
            this.btnRLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnRLimpiar.TabIndex = 11;
            this.btnRLimpiar.Text = "Limpiar";
            this.btnRLimpiar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Font = new System.Drawing.Font("Baby Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(303, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 49);
            this.label9.TabIndex = 12;
            this.label9.Text = "Registrar Clientes";
            // 
            // listActualizar
            // 
            this.listActualizar.FormattingEnabled = true;
            this.listActualizar.Location = new System.Drawing.Point(205, 86);
            this.listActualizar.Name = "listActualizar";
            this.listActualizar.Size = new System.Drawing.Size(237, 29);
            this.listActualizar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(510, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(159, 337);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 31);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtADocumento
            // 
            this.txtADocumento.Location = new System.Drawing.Point(230, 150);
            this.txtADocumento.Multiline = true;
            this.txtADocumento.Name = "txtADocumento";
            this.txtADocumento.Size = new System.Drawing.Size(96, 25);
            this.txtADocumento.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hug Me Tight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Correo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hug Me Tight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(107, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Telefono:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hug Me Tight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(109, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Direccion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Hug Me Tight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(109, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Nombre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Hug Me Tight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(107, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Documento:";
            // 
            // txtANombre
            // 
            this.txtANombre.Location = new System.Drawing.Point(230, 181);
            this.txtANombre.Multiline = true;
            this.txtANombre.Name = "txtANombre";
            this.txtANombre.Size = new System.Drawing.Size(96, 25);
            this.txtANombre.TabIndex = 24;
            // 
            // txtADireccion
            // 
            this.txtADireccion.Location = new System.Drawing.Point(230, 215);
            this.txtADireccion.Multiline = true;
            this.txtADireccion.Name = "txtADireccion";
            this.txtADireccion.Size = new System.Drawing.Size(96, 25);
            this.txtADireccion.TabIndex = 25;
            // 
            // txtATelefono
            // 
            this.txtATelefono.Location = new System.Drawing.Point(230, 252);
            this.txtATelefono.Multiline = true;
            this.txtATelefono.Name = "txtATelefono";
            this.txtATelefono.Size = new System.Drawing.Size(96, 25);
            this.txtATelefono.TabIndex = 26;
            // 
            // txtACorreo
            // 
            this.txtACorreo.Location = new System.Drawing.Point(230, 283);
            this.txtACorreo.Multiline = true;
            this.txtACorreo.Name = "txtACorreo";
            this.txtACorreo.Size = new System.Drawing.Size(96, 25);
            this.txtACorreo.TabIndex = 27;
            // 
            // dtgACliente
            // 
            this.dtgACliente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgACliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgACliente.Location = new System.Drawing.Point(358, 150);
            this.dtgACliente.Name = "dtgACliente";
            this.dtgACliente.RowTemplate.Height = 31;
            this.dtgACliente.Size = new System.Drawing.Size(392, 158);
            this.dtgACliente.TabIndex = 28;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(548, 86);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 28);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // listConsultar
            // 
            this.listConsultar.FormattingEnabled = true;
            this.listConsultar.Location = new System.Drawing.Point(243, 85);
            this.listConsultar.Name = "listConsultar";
            this.listConsultar.Size = new System.Drawing.Size(237, 29);
            this.listConsultar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hug Me Tight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(152, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // dtgConsultar
            // 
            this.dtgConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultar.Location = new System.Drawing.Point(114, 179);
            this.dtgConsultar.Name = "dtgConsultar";
            this.dtgConsultar.RowTemplate.Height = 31;
            this.dtgConsultar.Size = new System.Drawing.Size(581, 170);
            this.dtgConsultar.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(335, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 33);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // listEliminar
            // 
            this.listEliminar.FormattingEnabled = true;
            this.listEliminar.Location = new System.Drawing.Point(335, 145);
            this.listEliminar.Name = "listEliminar";
            this.listEliminar.Size = new System.Drawing.Size(237, 29);
            this.listEliminar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hug Me Tight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(230, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente";
            // 
            // frCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlPrincipal);
            this.Name = "frCliente";
            this.Text = "frCliente";
            this.tabControlPrincipal.ResumeLayout(false);
            this.pgRegistrar.ResumeLayout(false);
            this.pgRegistrar.PerformLayout();
            this.pgActualizar.ResumeLayout(false);
            this.pgActualizar.PerformLayout();
            this.pgConsultar.ResumeLayout(false);
            this.pgConsultar.PerformLayout();
            this.pgEliminar.ResumeLayout(false);
            this.pgEliminar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgACliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage pgRegistrar;
        private Label label1;
        private TabPage pgActualizar;
        private Label inCliente;
        private TabPage pgConsultar;
        private TabPage pgEliminar;
        private Panel panel1;
        private RadioButton rbEliminar;
        private RadioButton rbConsultar;
        private RadioButton rbActualizar;
        private RadioButton rbRegistrar;
        private Label label9;
        private Button btnRLimpiar;
        private Button btnAgregar;
        private TextBox txtRCorreo;
        private TextBox txtRTelefono;
        private TextBox txtRDireccion;
        private TextBox txtRNombre;
        private TextBox txtRDocumento;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dtgACliente;
        private TextBox txtACorreo;
        private TextBox txtATelefono;
        private TextBox txtADireccion;
        private TextBox txtANombre;
        private Button btnActualizar;
        private TextBox txtADocumento;
        private Label label2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnBuscar;
        private ComboBox listActualizar;
        private DataGridView dtgConsultar;
        private Button btnConsultar;
        private ComboBox listConsultar;
        private Label label3;
        private Button btnEliminar;
        private ComboBox listEliminar;
        private Label label4;
    }
}